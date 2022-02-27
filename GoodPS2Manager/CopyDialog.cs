using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodPS2Manager
{
    public partial class CopyDialog : Form
    {
        OPLFolderStructure loadedOPLStructure;
        ToolStripProgressBar mainProgressBar;
        ToolStripStatusLabel progressLabel;
        CommonOpenFileDialog addGameDialog = new CommonOpenFileDialog
        {
            Multiselect = true,
            RestoreDirectory = true,
            EnsureFileExists = true,
            EnsurePathExists = true,
            Title = "Select ISO files to add to the OPL folder"
        };

        Action<CopyModel, IOExtensions.TransferProgress> progressDelegate;

        List<CopyModel> copyJobs = new List<CopyModel>();

        private CancellationTokenSource _cts;

        public CopyDialog(OPLFolderStructure loadedOPLStructure, ToolStripProgressBar mainProgressBar, ToolStripStatusLabel progressLabel, List<CopyModel> copyJobs, Action<CopyModel, IOExtensions.TransferProgress> progressDelegate)
        {
            InitializeComponent();
            this.loadedOPLStructure = loadedOPLStructure;
            this.mainProgressBar = mainProgressBar;
            this.progressLabel = progressLabel;
            this.copyJobs = copyJobs;
            this.progressDelegate = progressDelegate;

            olvProgress.Renderer = new BarRenderer(0,100);
            CopyJobList.OwnerDraw = true;
            CopyJobList.SetObjects(copyJobs);

            CheckButtons();
        }


        #region Event Handlers
        private void AddImagesButton_Click(object sender, EventArgs e)
        {
            if (addGameDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                copyJobs.AddRange(addGameDialog.FileNames.Select(f => new CopyModel
                {
                    Source = f,
                    Status = OPLFolderStructure.CopyStatus.ReadyToCopy,
                    Progress = 0
                }).Where(x => !copyJobs.Any(y => y.Source == x.Source)).ToList());

                CopyJobList.SetObjects(copyJobs);
                // Enable the copy button because we can't if items have been added/removed from the listbox without trouble
                CheckButtons();
            }
        }

        private void CheckButtons()
        {
            CancelCopyButton.Enabled = copyJobs.Any(x => x.Status == OPLFolderStructure.CopyStatus.Copying); 
            StartCopyButton.Enabled = copyJobs.Count > 0 && !copyJobs.Any(x => x.Status == OPLFolderStructure.CopyStatus.Copying);
            RemoveImagesButton.Enabled = copyJobs.Count > 0 && !copyJobs.Any(x => x.Status == OPLFolderStructure.CopyStatus.Copying);
        }

        private void RemoveImagesButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems();
        }

        private async void StartCopyButton_Click(object sender, EventArgs e)
        {
            StartCopyButton.Enabled = false;
            CancelCopyButton.Enabled = true;

            // Setup progress bar
            float progressValue = 0;
            mainProgressBar.Enabled = true;

            // Setup progress handler
            var progressHandler = new Progress<int>(value =>
            {
                progressValue += value;
                float percentage = progressValue / addGameDialog.FileNames.Count() * 100;
                mainProgressBar.Value = (int)percentage;
                OverallCopyProgressBar.Value = (int)percentage;
                progressLabel.Text = $"{progressValue} out of {addGameDialog.FileNames.Count()} copied";
            });
            
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            try
            {
                // Start copying our files
                await Task.Run(() =>
                {
                    foreach(var copyJob in copyJobs)
                    {
                        copyJob.Status = loadedOPLStructure.CopyGameToFolder(copyJob.Source, (progress) => progressDelegate(copyJob, progress), token);
                    }
                });

                var failedCopies = copyJobs.Where(x => x.Status != OPLFolderStructure.CopyStatus.Success).ToList();

                // If we have failed copies then let the user know
                if (failedCopies.Count > 0)
                {
                    var realSuccessfulCount = copyJobs.Count - failedCopies.Count;

                    MessageBox.Show($"Issues occured during copy\n" +
                        $"Successfully copied {realSuccessfulCount} Games\n" +
                        $"Failed to copy {failedCopies.Count} files\n" +
                        $"The following files failed\n" +
                        $"{string.Join("\n", failedCopies.Select(x => x.Source))}");


                    CopyJobList.SetObjects(copyJobs);
                }
                else
                {
                    MessageBox.Show($"Successfully copied {copyJobs.Count} Games");
                }

                // Reset our interface to show new items
                //LoadOPLFolder(loadedOPLStructure.RootFolder);

                // Let the user know the operation has been completed
                mainProgressBar.Enabled = false;
                CheckButtons();
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Copy operation Cancelled");

                mainProgressBar.Enabled = false;
                mainProgressBar.Value = 0;
                OverallCopyProgressBar.Value = 0;

                progressLabel.Text = $"Copy operation was Cancelled";
            }
            CheckButtons();
            CancelCopyButton.Enabled = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelCopyButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }

        private void CopyJobList_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            CheckButtons();
        }

        private void CopyJobList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveSelectedItems();
            }
        }

        #endregion

        private void RemoveSelectedItems()
        {
            foreach (CopyModel obj in CopyJobList.SelectedObjects)
            {
                copyJobs.RemoveAll(x => x.Source == obj.Source);
            }
            CopyJobList.SetObjects(copyJobs);
        }


    }

    public class CopyModel : INotifyPropertyChanged
    {
        private OPLFolderStructure.CopyStatus status;
        private string source;
        private int progress;

        public string Source { get => source; set
            {
                source = value;
                OnPropertyChanged(nameof(Source));
            }
        }

        public string StatusDisplay
        {
            get
            {
                return status switch
                {
                    OPLFolderStructure.CopyStatus.Failed => "Failed",
                    OPLFolderStructure.CopyStatus.SourceDoesntExist => "Source Doesn't Exist",
                    OPLFolderStructure.CopyStatus.FileAlreadyExists => "Duplicate Game",
                    OPLFolderStructure.CopyStatus.Cancelled => "Cancelled",
                    OPLFolderStructure.CopyStatus.FolderDoesntExist => "Destination Folder Doesn't exist",
                    OPLFolderStructure.CopyStatus.Success => "Completed!",
                    OPLFolderStructure.CopyStatus.None => "None",
                    OPLFolderStructure.CopyStatus.ReadyToCopy => "Ready To Copy",
                    OPLFolderStructure.CopyStatus.Copying => "Copying",
                    OPLFolderStructure.CopyStatus.FileNotImage => "File is not image",
                    _ => "Unknown?",
                };
            }
        }

        public OPLFolderStructure.CopyStatus Status { get => status; set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public int Progress
        {
            get => progress; set 
            { 
                progress = value;
                OnPropertyChanged(nameof(Progress));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public CopyModel()
        {

        }
    }
}
