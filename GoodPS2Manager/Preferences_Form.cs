using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodPS2Manager
{
    public partial class Preferences_Form : Form
    {
        public Preferences pendingPreferences;
        public bool savePending;

        public Preferences_Form(Preferences preferencesToLoad)
        {
            InitializeComponent();

            pendingPreferences = preferencesToLoad;
            DefaultOPLPathTextbox.Text = pendingPreferences.DefaultOPLPath;
            LoadOPLOnStartupCheckbox.Checked = pendingPreferences.LoadOPLFolderOnStartup;
        }

        #region Dialog Close Methods
        private void SavePendingPreferences()
        {
            if (pendingPreferences.ValidatePreferences())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("The Preferences are invalid");
            }
        }

        private void CancelPendingPreferences()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Event Handlers
        private void Preferences_Form_Load(object sender, EventArgs e)
        {
            savePending = false;
        }

        private void CancelPreferenceButton_Click(object sender, EventArgs e)
        {
            CancelPendingPreferences();
        }

        private void SavePreferencesButton_Click(object sender, EventArgs e)
        {
            SavePendingPreferences();
        }

        private void Preferences_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                // Check to make sure there's no preferences to save before closing
                if (savePending)
                {
                    var messageResult = MessageBox.Show("Do you want to save your changes?", "Save Changes", MessageBoxButtons.YesNo);
                    if (messageResult == DialogResult.Yes)
                    {
                        SavePendingPreferences();
                        return;
                    }
                }
            }
        }

        private void DefaultOPLPathTextbox_TextChanged(object sender, EventArgs e)
        {
            savePending = true;
            pendingPreferences.DefaultOPLPath = DefaultOPLPathTextbox.Text;
        }
        private void OPLFolderBrowseButton_Click(object sender, EventArgs e)
        {

            var folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = pendingPreferences.DefaultOPLPath,
                IsFolderPicker = true
            };
            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DefaultOPLPathTextbox.Text = folderDialog.FileName;
            }
        }
        private void LoadOPLOnStartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            pendingPreferences.LoadOPLFolderOnStartup = ((CheckBox)sender).Checked;
        }
        #endregion

    }
}
