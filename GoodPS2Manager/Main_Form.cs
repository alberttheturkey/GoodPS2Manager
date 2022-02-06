using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.WindowsAPICodePack.Dialogs;
using ByteSizeLib;

namespace GoodPS2Manager
{
    public partial class GoodPS2Manger_Main_Form : Form
    {
        Preferences currentPreferences = new Preferences();
        OPLFolderStructure loadedOPLStructure;

        public GoodPS2Manger_Main_Form()
        {
            InitializeComponent();
        }
        #region Event Handlers
        private void GoodPS2Manger_Main_Form_Load(object sender, EventArgs e)
        {
            // Load in our title text and saved preferences
            Text = $"Good PS2 Manager V{Assembly.GetExecutingAssembly().GetName().Version.ToString(2)}";
            currentPreferences = Properties.Settings.Default.Preferences;
            
            // only load OPL folder on startup
            if (currentPreferences.LoadOPLFolderOnStartup)
            {
                LoadOPLFolder(currentPreferences.DefaultOPLPath);
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences_Form preferenceForm = new Preferences_Form(currentPreferences);
            var preferencesResult = preferenceForm.ShowDialog();
            if(preferencesResult == DialogResult.OK)
            {
                currentPreferences = preferenceForm.pendingPreferences;
                //MessageBox.Show($"Saved Successfully {currentPreferences.DefaultOPLPath}");
            }
            else if(preferencesResult == DialogResult.Cancel)
            {
                //MessageBox.Show($"Preferences was closed without saving changes {currentPreferences.DefaultOPLPath}");
            }
        }

        private void GoodPS2Manger_Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Preferences = currentPreferences;
            Properties.Settings.Default.Save();
        }

        private void openOPLFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = currentPreferences.DefaultOPLPath,
                IsFolderPicker = true
            };

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                LoadOPLFolder(folderDialog.FileName);
            }
        }
        private void refreshOPLFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOPLFolder(currentPreferences.DefaultOPLPath);
        }

        private void addGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addGameDialog = new CommonOpenFileDialog
            {
                Multiselect = true,
                RestoreDirectory = true,
                EnsureFileExists = true,
                EnsurePathExists = true,
                Title = "Select ISO files to add to the OPL folder"
            };

            if (addGameDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var failedCopies = (from file in addGameDialog.FileNames
                                    where !loadedOPLStructure.CopyGameToFolder(file)
                                    select file).ToList();

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

                LoadOPLFolder(loadedOPLStructure.RootFolder);
            }
        }

        #endregion

        #region Helper Methods
        public void LoadOPLFolder(string path)
        {
            try
            {
                loadedOPLStructure = new OPLFolderStructure(path);

                // We need to clear this before we load anything in or else it'll just duplicate entries
                GamesListView.Items.Clear();
                AddGamesToList(loadedOPLStructure.DVD.GamesList);
                AddGamesToList(loadedOPLStructure.CD.GamesList);

                // Update any other interface elements that need to be changed once the folder is loaded
                OPLStructureLabel.Text = loadedOPLStructure.ToString();
                FolderStatusLabel.Text = $"Current Folder: {loadedOPLStructure.RootFolder}";
                addGamesToolStripMenuItem.Enabled = true;
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
        #endregion

    }
}
