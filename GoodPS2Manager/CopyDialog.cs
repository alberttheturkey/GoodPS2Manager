using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        List<CopyModel> copyJobs = new List<CopyModel>();

        private CancellationTokenSource _cts;

        List<string> selectedImages = new List<string>();

        public CopyDialog(OPLFolderStructure loadedOPLStructure, ToolStripProgressBar mainProgressBar, ToolStripStatusLabel progressLabel)
        {
            InitializeComponent();
            this.loadedOPLStructure = loadedOPLStructure;
            this.mainProgressBar = mainProgressBar;
            this.progressLabel = progressLabel;
        }

        private void AddImagesButton_Click(object sender, EventArgs e)
        {
            if (addGameDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                selectedImages.AddRange(addGameDialog.FileNames.Where(image => !selectedImages.Contains(image)));

                foreach (string imageFilePath in selectedImages)
                {
                    copyJobs.Add(new CopyModel
                    {
                        Source = imageFilePath,
                        Status = "Ready To Copy",
                        Progress = 0
                    });
                    objectListView1.SetObjects(copyJobs);
                }

                // Enable the copy button because we can't if items have been added/removed from the listbox without trouble
                StartCopyButton.Enabled = true;
            }
        }
        private void RemoveImagesButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem image in GameCopyList.SelectedItems)
            {
                GameCopyList.Items.Remove(image);
            }
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
            var progress = progressHandler as IProgress<int>;

            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            try
            {
                // Start copying our files
                var failedCopies = await Task.Run(() =>
                {
                    return addGameDialog.FileNames.Where(file =>
                        !loadedOPLStructure.CopyGameToFolder(file, progress, token))
                        .ToList();
                });

                // If we have failed copies then let the user know
                if (failedCopies.Count > 0)
                {
                    var realSuccessfulCount = addGameDialog.FileNames.Count() - failedCopies.Count;

                    MessageBox.Show($"Issues occured during copy\n" +
                        $"Successfully copied {realSuccessfulCount} Games\n" +
                        $"Failed to copy {failedCopies.Count} files\n" +
                        $"The following files failed {string.Join("\n", failedCopies)}");

                }
                else
                {
                    MessageBox.Show($"Successfully copied {addGameDialog.FileNames.Count()} Games");
                }

                // Reset our interface to show new items
                //LoadOPLFolder(loadedOPLStructure.RootFolder);

                // Let the user know the operation has been completed
                progressLabel.Text = $"Copy Complete!";
                mainProgressBar.Enabled = false;
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Copy operation Cancelled");

                mainProgressBar.Enabled = false;
                mainProgressBar.Value = 0;
                OverallCopyProgressBar.Value = 0;

                progressLabel.Text = $"Copy operation was Cancelled";
            }

            StartCopyButton.Enabled = true;
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

        private void GameCopyList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(((ListView)sender).SelectedItems.Count > 0)
            {
                RemoveImagesButton.Enabled = true;
            }
            else
            {
                RemoveImagesButton.Enabled = false;
            }
        }

        private void CopyDialog_Load(object sender, EventArgs e)
        {

        }
    }

    public class CopyModel
    {
        public string Source { get; set; }
        public string Status { get; set; }
        public int Progress { get; set; }
    }
}
