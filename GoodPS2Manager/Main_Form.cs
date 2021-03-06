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
        #endregion

        #region Helper Methods
        public void LoadOPLFolder(string path)
        {
            try
            {
                loadedOPLStructure = new OPLFolderStructure(path);
                OPLStructureLabel.Text = loadedOPLStructure.ToString();
                FolderStatusLabel.Text = $"Current Folder: {loadedOPLStructure.RootFolder}";

                // We need to clear this before we load anything in or else it'll just duplicate entries
                GamesListView.Items.Clear();

                // Add in out DVD list 
                // TODO: add in CD games also
                foreach (Game game in loadedOPLStructure.DVD.GamesList) {
                    var size = ByteSize.FromBytes(game.Size);
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
            catch (Exception e){
                MessageBox.Show($"An error has occured whilst attempting to load OPL Folder. \nError Message:\n{e.Message}", "OPL Load Error");
            }
        }
        #endregion

        private void GamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
