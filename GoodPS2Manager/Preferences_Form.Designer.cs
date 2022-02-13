﻿namespace GoodPS2Manager
{
    partial class Preferences_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DefaultOPLPathTextbox = new System.Windows.Forms.TextBox();
            this.OPLFolderBrowseButton = new System.Windows.Forms.Button();
            this.DefaultOPLFolderLabel = new System.Windows.Forms.Label();
            this.SavePreferencesButton = new System.Windows.Forms.Button();
            this.CancelPreferenceButton = new System.Windows.Forms.Button();
            this.LoadOPLOnStartupCheckbox = new System.Windows.Forms.CheckBox();
            this.PreferencesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CheckOPLFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DefaultOPLPathTextbox
            // 
            this.DefaultOPLPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultOPLPathTextbox.Location = new System.Drawing.Point(171, 34);
            this.DefaultOPLPathTextbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DefaultOPLPathTextbox.Name = "DefaultOPLPathTextbox";
            this.DefaultOPLPathTextbox.Size = new System.Drawing.Size(285, 20);
            this.DefaultOPLPathTextbox.TabIndex = 0;
            this.PreferencesToolTip.SetToolTip(this.DefaultOPLPathTextbox, "This is the default OPL Folder to load on startup");
            this.DefaultOPLPathTextbox.TextChanged += new System.EventHandler(this.DefaultOPLPathTextbox_TextChanged);
            // 
            // OPLFolderBrowseButton
            // 
            this.OPLFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OPLFolderBrowseButton.Location = new System.Drawing.Point(458, 31);
            this.OPLFolderBrowseButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.OPLFolderBrowseButton.Name = "OPLFolderBrowseButton";
            this.OPLFolderBrowseButton.Size = new System.Drawing.Size(125, 25);
            this.OPLFolderBrowseButton.TabIndex = 1;
            this.OPLFolderBrowseButton.Text = "Browse";
            this.OPLFolderBrowseButton.UseVisualStyleBackColor = true;
            this.OPLFolderBrowseButton.Click += new System.EventHandler(this.OPLFolderBrowseButton_Click);
            // 
            // DefaultOPLFolderLabel
            // 
            this.DefaultOPLFolderLabel.AutoSize = true;
            this.DefaultOPLFolderLabel.Location = new System.Drawing.Point(72, 37);
            this.DefaultOPLFolderLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DefaultOPLFolderLabel.Name = "DefaultOPLFolderLabel";
            this.DefaultOPLFolderLabel.Size = new System.Drawing.Size(97, 13);
            this.DefaultOPLFolderLabel.TabIndex = 2;
            this.DefaultOPLFolderLabel.Text = "Default OPL Folder";
            // 
            // SavePreferencesButton
            // 
            this.SavePreferencesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePreferencesButton.Location = new System.Drawing.Point(331, 292);
            this.SavePreferencesButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SavePreferencesButton.Name = "SavePreferencesButton";
            this.SavePreferencesButton.Size = new System.Drawing.Size(125, 25);
            this.SavePreferencesButton.TabIndex = 4;
            this.SavePreferencesButton.Text = "Save";
            this.SavePreferencesButton.UseVisualStyleBackColor = true;
            this.SavePreferencesButton.Click += new System.EventHandler(this.SavePreferencesButton_Click);
            // 
            // CancelPreferenceButton
            // 
            this.CancelPreferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelPreferenceButton.Location = new System.Drawing.Point(458, 292);
            this.CancelPreferenceButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CancelPreferenceButton.Name = "CancelPreferenceButton";
            this.CancelPreferenceButton.Size = new System.Drawing.Size(125, 25);
            this.CancelPreferenceButton.TabIndex = 5;
            this.CancelPreferenceButton.Text = "Cancel";
            this.CancelPreferenceButton.UseVisualStyleBackColor = true;
            this.CancelPreferenceButton.Click += new System.EventHandler(this.CancelPreferenceButton_Click);
            // 
            // LoadOPLOnStartupCheckbox
            // 
            this.LoadOPLOnStartupCheckbox.AutoSize = true;
            this.LoadOPLOnStartupCheckbox.Location = new System.Drawing.Point(171, 54);
            this.LoadOPLOnStartupCheckbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LoadOPLOnStartupCheckbox.Name = "LoadOPLOnStartupCheckbox";
            this.LoadOPLOnStartupCheckbox.Size = new System.Drawing.Size(156, 17);
            this.LoadOPLOnStartupCheckbox.TabIndex = 6;
            this.LoadOPLOnStartupCheckbox.Text = "Load OPL Folder on startup";
            this.PreferencesToolTip.SetToolTip(this.LoadOPLOnStartupCheckbox, "Check this box to have Good PS2 Manager load the above specified OPL Folder on st" +
        "artup");
            this.LoadOPLOnStartupCheckbox.UseVisualStyleBackColor = true;
            this.LoadOPLOnStartupCheckbox.CheckedChanged += new System.EventHandler(this.LoadOPLOnStartupCheckbox_CheckedChanged);
            // 
            // PreferencesToolTip
            // 
            this.PreferencesToolTip.OwnerDraw = true;
            // 
            // CheckOPLFolderCheckBox
            // 
            this.CheckOPLFolderCheckBox.AutoSize = true;
            this.CheckOPLFolderCheckBox.Checked = true;
            this.CheckOPLFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckOPLFolderCheckBox.Location = new System.Drawing.Point(171, 68);
            this.CheckOPLFolderCheckBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CheckOPLFolderCheckBox.Name = "CheckOPLFolderCheckBox";
            this.CheckOPLFolderCheckBox.Size = new System.Drawing.Size(234, 17);
            this.CheckOPLFolderCheckBox.TabIndex = 7;
            this.CheckOPLFolderCheckBox.Text = "Check OPL folder for missing folders on load";
            this.PreferencesToolTip.SetToolTip(this.CheckOPLFolderCheckBox, "Check this box to have Good PS2 Manager load the above specified OPL Folder on st" +
        "artup");
            this.CheckOPLFolderCheckBox.UseVisualStyleBackColor = true;
            this.CheckOPLFolderCheckBox.CheckedChanged += new System.EventHandler(this.CheckOPLFolderCheckBox_CheckedChanged);
            // 
            // Preferences_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 327);
            this.Controls.Add(this.CheckOPLFolderCheckBox);
            this.Controls.Add(this.LoadOPLOnStartupCheckbox);
            this.Controls.Add(this.CancelPreferenceButton);
            this.Controls.Add(this.SavePreferencesButton);
            this.Controls.Add(this.DefaultOPLFolderLabel);
            this.Controls.Add(this.OPLFolderBrowseButton);
            this.Controls.Add(this.DefaultOPLPathTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Preferences_Form";
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_Form_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DefaultOPLPathTextbox;
        private System.Windows.Forms.Button OPLFolderBrowseButton;
        private System.Windows.Forms.Label DefaultOPLFolderLabel;
        private System.Windows.Forms.Button SavePreferencesButton;
        private System.Windows.Forms.Button CancelPreferenceButton;
        private System.Windows.Forms.ToolTip PreferencesToolTip;
        private System.Windows.Forms.CheckBox LoadOPLOnStartupCheckbox;
        private System.Windows.Forms.CheckBox CheckOPLFolderCheckBox;
    }
}