using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.WindowsAPICodePack.Dialogs;
using ByteSizeLib;
using System.Diagnostics;

namespace GoodPS2Manager
{
    public partial class GoodPS2Manger_Main_Form : Form
    {
        Preferences currentPreferences = new Preferences();
        OPLFolderStructure loadedOPLStructure;
        public List<CopyModel> copyJobs = new List<CopyModel>();
        public ImageDownloader imageDownloader;

        public int leftHandIndex, rightHandIndex;

        public GoodPS2Manger_Main_Form()
        {
            InitializeComponent();
        }
        #region Event Handlers
        private void GoodPS2Manger_Main_Form_Load(object sender, EventArgs e)
        {
            leftHandIndex = Controls.GetChildIndex(SidebarPanel);
            rightHandIndex = Controls.GetChildIndex(GameListPanel);

            // Load in our title text and saved preferences
            Text = $"Good PS2 Manager V{Assembly.GetExecutingAssembly().GetName().Version.ToString(2)}";
            currentPreferences = Properties.Settings.Default.Preferences ?? currentPreferences;
            
            SetupInterfaceForPreferences(currentPreferences);

            // only load OPL folder on startup
            if (currentPreferences != null && currentPreferences.LoadOPLFolderOnStartup)
            {
                LoadOPLFolder(currentPreferences.DefaultOPLPath);
            }
        }

        private void GoodPS2Manger_Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Preferences = currentPreferences;
            Properties.Settings.Default.Save();
        }

        private void OpenOPLFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(loadedOPLStructure.RootFolder);
        }

        #region Menu Events
        private void ShowStatusBarMenuItem_Click(object sender, EventArgs e)
        {
            var isChecked = ((ToolStripMenuItem)sender).Checked;
            StatusStrip.Visible = isChecked;
            currentPreferences.ShowStatusBar = isChecked;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences_Form preferenceForm = new Preferences_Form(currentPreferences);
            var preferencesResult = preferenceForm.ShowDialog();
            if (preferencesResult == DialogResult.OK)
            {
                currentPreferences = preferenceForm.pendingPreferences;
            }
        }

        private void openOPLFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = currentPreferences?.DefaultOPLPath ?? null,
                IsFolderPicker = true
            };

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                LoadOPLFolder(folderDialog.FileName);
            }
        }
        private void refreshOPLFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            LoadOPLFolder(loadedOPLStructure.RootFolder);
        }

        private void addGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var copyDialog = new CopyDialog(loadedOPLStructure, MainProgressBar, ProgressPercentageLabel, copyJobs, HandleProgress);
            copyDialog.ShowDialog();
        }
        private void artDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var copyDialog = new ArtDownload_Form(loadedOPLStructure, imageDownloader);
            copyDialog.ShowDialog();
        }

        private void createOPLFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                EnsurePathExists = false,
                EnsureFileExists = false,
                EnsureValidNames = false,
            };

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                LoadOPLFolder(folderDialog.FileName, true);

                if (!loadedOPLStructure.FolderExists)
                {
                    MessageBox.Show("OPL folder creation failed");
                }
                else if (loadedOPLStructure.MissingFolders)
                {
                    MessageBox.Show("OPL folder created but folders are missing");
                }
                else
                {
                    MessageBox.Show("OPL folder successfully created");
                }
            }
        }

        private void rightHandSideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSidebarLocation(Sidebar.SidebarLocation.Right, hideToolStripMenuItem.Checked);
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSidebarLocation(rightHandSideToolStripMenuItem.Checked ? Sidebar.SidebarLocation.Right : Sidebar.SidebarLocation.Left, hideToolStripMenuItem.Checked);
        }

        private void leftHandSideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSidebarLocation(Sidebar.SidebarLocation.Left, hideToolStripMenuItem.Checked);
        }

        private void RecentFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOPLFolder(((ToolStripMenuItem)sender).Text);
        }

        #endregion

        #endregion

        #region Helper Methods
        public void LoadOPLFolder(string path, bool createFolder = false)
        {
            try
            {
                loadedOPLStructure = new OPLFolderStructure(path, createFolder);

                if (loadedOPLStructure.FailedLoadsPresent)
                {
                    var messageList = "";
                    foreach(var failedLoad in loadedOPLStructure.FailedLoads)
                    {
                        messageList += $"\n{failedLoad.Key} - {failedLoad.Value}";
                    }

                    // TODO: Turn this into a log instead of a message box
                    MessageBox.Show("The following games failed to load" + messageList, "Games Failed To Load");
                }

                if (loadedOPLStructure.MissingFolders && currentPreferences.CheckOPLFolderOnLoad && !createFolder)
                {
                    if(MessageBox.Show("This OPL folder is missing some folders, Do you want to add them?", "OPL Structure Missing Folders", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        loadedOPLStructure.CreateMissingOPLFolders();
                    }
                }

                // We need to clear this before we load anything in or else it'll just duplicate entries
                GamesListView.Items.Clear();
                AddGamesToList(loadedOPLStructure.DVD.GamesList);
                AddGamesToList(loadedOPLStructure.CD.GamesList);

                // Update any other interface elements that need to be changed once the folder is loaded
                OPLStructureLabel.Text = loadedOPLStructure.ToString();
                FolderStatusLabel.Text = $"Current Folder: {loadedOPLStructure.RootFolder}";
                addGamesToolStripMenuItem.Enabled = true;
                OpenOPLFolderButton.Enabled = true;
                refreshOPLFolderToolStripMenuItem.Enabled = true;
                
                // Make sure we're not making an infinitely large "RecentFolders" list
                currentPreferences.RecentFolders = currentPreferences.RecentFolders.Distinct().ToList();
                if (currentPreferences.RecentFolders.Any(x => x == loadedOPLStructure.RootFolder))
                {
                    currentPreferences.RecentFolders.Add(loadedOPLStructure.RootFolder);
                }

                SetupInterfaceForPreferences(currentPreferences);
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occured whilst attempting to load OPL Folder. \nError Message:\n{e.Message}", "OPL Load Error");
            }
        }

        private void AddGamesToList(List<Game> gamesList)
        {
            // LINQ query to add all the games we've been passed into the list
            foreach (var (game, size) in
            from Game game in gamesList
            let size = ByteSize.FromBytes(game.Size)
            select (game, size))
            {
                GamesListView.Items.Add(new ListViewItem(
                    new string[] {
                            game.Name,
                            game.Region.ToString(),
                            game.Type.ToString(),
                            game.ID,
                            game.VolumeName,
                            $"{string.Format("{0:0.0}", size.LargestWholeNumberDecimalValue)} {size.LargestWholeNumberDecimalSymbol}"
                    })
                );
            }
        }

        private void SetupInterfaceForPreferences(Preferences currentPreferences)
        {
            // Setup our sidebar
            var sidebar = currentPreferences.Sidebar;
            SetSidebarLocation(sidebar.Location, sidebar.Hidden);

            StatusStrip.Visible = currentPreferences.ShowStatusBar;
            ShowStatusBarMenuItem.Checked = currentPreferences.ShowStatusBar;

            // Clear then populate our recent folders
            recentOPLFolderToolStripMenuItem.DropDownItems.Clear();
            foreach (var folder in currentPreferences.RecentFolders.Distinct())
            {
                recentOPLFolderToolStripMenuItem.DropDownItems.Add(folder,null, RecentFolderToolStripMenuItem_Click);
            }
        }

        private void SetSidebarLocation(Sidebar.SidebarLocation location, bool hidden)
        {
            // Set the visibility of the sidebar and it's splitter
            SidebarPanel.Visible = !hidden;
            MainInterfaceSplitter.Visible = !hidden;

            // Set the checkboxes on the menu
            hideToolStripMenuItem.Checked = hidden;
            rightHandSideToolStripMenuItem.Checked = location == Sidebar.SidebarLocation.Right;
            leftHandSideToolStripMenuItem.Checked = location == Sidebar.SidebarLocation.Left;

            // Set sidebar position according to location specified, if hidden is set then
            // sidebar needs to be in the left hand side to hide, this is reset to the right
            // side if hidden is set false and the sidebar location is on the right
            if (hidden || location == Sidebar.SidebarLocation.Left)
            {
                Controls.SetChildIndex(SidebarPanel, leftHandIndex);
                Controls.SetChildIndex(GameListPanel, rightHandIndex);
                SidebarPanel.Dock = DockStyle.Left;
                GameListPanel.Dock = DockStyle.Fill;
            }
            else
            {
                Controls.SetChildIndex(SidebarPanel, rightHandIndex);
                Controls.SetChildIndex(GameListPanel, leftHandIndex);
                SidebarPanel.Dock = DockStyle.Fill;
                GameListPanel.Dock = DockStyle.Left;
            }

            // Save the preference so that when the user closes and re-opens the program it remembers the position
            currentPreferences.Sidebar.Location = location;
            currentPreferences.Sidebar.Hidden = hidden;
        }

        #endregion

        #region Progress Methods
        private void HandleProgress(CopyModel copyJob, IOExtensions.TransferProgress progress)
        {
            if (InvokeRequired)
            {
                Invoke(new HandleProgressDelegate(HandleProgressShower), copyJob, progress);
                return;
            }

        }

        private delegate void HandleProgressDelegate(CopyModel copyJob, IOExtensions.TransferProgress progress);

        private void HandleProgressShower(CopyModel copyJob, IOExtensions.TransferProgress progress)
        {
            var currentJob = copyJobs.Where(x => copyJob.Source == x.Source).FirstOrDefault();
            currentJob.Progress = (int)progress.Percentage;
            if(progress.Percentage > 0)
            {
                currentJob.Status = OPLFolderStructure.CopyStatus.Copying;
            }
            
            if(progress.Percentage >= 100)
            {
                currentJob.Status = OPLFolderStructure.CopyStatus.Success;
            }
                        
            MainProgressBar.Value = copyJobs.Sum(x => x.Progress) / copyJobs.Count;
        }

        #endregion
    }
}
