namespace GoodPS2Manager
{
    partial class GoodPS2Manger_Main_Form
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCopyProgressDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPLConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPLStructureLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.FolderStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressPercentageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GamesListView = new System.Windows.Forms.ListView();
            this.GameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiscType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VolumeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1832, 33);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOPLFolderToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openOPLFolderToolStripMenuItem
            // 
            this.openOPLFolderToolStripMenuItem.Name = "openOPLFolderToolStripMenuItem";
            this.openOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.openOPLFolderToolStripMenuItem.Text = "Open OPL Folder";
            this.openOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.openOPLFolderToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshOPLFolderToolStripMenuItem,
            this.addGamesToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // refreshOPLFolderToolStripMenuItem
            // 
            this.refreshOPLFolderToolStripMenuItem.Name = "refreshOPLFolderToolStripMenuItem";
            this.refreshOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.refreshOPLFolderToolStripMenuItem.Text = "Refresh OPL Folder";
            this.refreshOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.refreshOPLFolderToolStripMenuItem_Click);
            // 
            // addGamesToolStripMenuItem
            // 
            this.addGamesToolStripMenuItem.Enabled = false;
            this.addGamesToolStripMenuItem.Name = "addGamesToolStripMenuItem";
            this.addGamesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addGamesToolStripMenuItem.Text = "Add Games";
            this.addGamesToolStripMenuItem.Click += new System.EventHandler(this.addGamesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCopyProgressDialogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // openCopyProgressDialogToolStripMenuItem
            // 
            this.openCopyProgressDialogToolStripMenuItem.Name = "openCopyProgressDialogToolStripMenuItem";
            this.openCopyProgressDialogToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.openCopyProgressDialogToolStripMenuItem.Text = "Open Copy Progress Dialog";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPLConfigToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // oPLConfigToolStripMenuItem
            // 
            this.oPLConfigToolStripMenuItem.Name = "oPLConfigToolStripMenuItem";
            this.oPLConfigToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.oPLConfigToolStripMenuItem.Text = "OPL Config";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OPLStructureLabel
            // 
            this.OPLStructureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OPLStructureLabel.AutoSize = true;
            this.OPLStructureLabel.Location = new System.Drawing.Point(1430, 35);
            this.OPLStructureLabel.Name = "OPLStructureLabel";
            this.OPLStructureLabel.Size = new System.Drawing.Size(122, 20);
            this.OPLStructureLabel.TabIndex = 1;
            this.OPLStructureLabel.Text = "Nothing Loaded";
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderStatusLabel,
            this.MainProgressBar,
            this.ProgressPercentageLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 930);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1832, 32);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // FolderStatusLabel
            // 
            this.FolderStatusLabel.Name = "FolderStatusLabel";
            this.FolderStatusLabel.Size = new System.Drawing.Size(185, 25);
            this.FolderStatusLabel.Text = "No OPL folder loaded";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // ProgressPercentageLabel
            // 
            this.ProgressPercentageLabel.Name = "ProgressPercentageLabel";
            this.ProgressPercentageLabel.Size = new System.Drawing.Size(0, 25);
            // 
            // GamesListView
            // 
            this.GamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamesListView.CheckBoxes = true;
            this.GamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameName,
            this.GameRegion,
            this.DiscType,
            this.GameID,
            this.VolumeName,
            this.GameSize});
            this.GamesListView.FullRowSelect = true;
            this.GamesListView.GridLines = true;
            this.GamesListView.HideSelection = false;
            this.GamesListView.Location = new System.Drawing.Point(-4, 40);
            this.GamesListView.Name = "GamesListView";
            this.GamesListView.Size = new System.Drawing.Size(1426, 882);
            this.GamesListView.TabIndex = 3;
            this.GamesListView.UseCompatibleStateImageBehavior = false;
            this.GamesListView.View = System.Windows.Forms.View.Details;
            // 
            // GameName
            // 
            this.GameName.Text = "Name";
            this.GameName.Width = 185;
            // 
            // GameRegion
            // 
            this.GameRegion.Text = "Region";
            // 
            // DiscType
            // 
            this.DiscType.Text = "Type";
            // 
            // GameID
            // 
            this.GameID.Text = "ID";
            this.GameID.Width = 100;
            // 
            // VolumeName
            // 
            this.VolumeName.Text = "Volume Name";
            this.VolumeName.Width = 95;
            // 
            // GameSize
            // 
            this.GameSize.Text = "Size";
            // 
            // GoodPS2Manger_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 962);
            this.Controls.Add(this.GamesListView);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.OPLStructureLabel);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(997, 991);
            this.Name = "GoodPS2Manger_Main_Form";
            this.Text = "Good PS2 Manager Version";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoodPS2Manger_Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.GoodPS2Manger_Main_Form_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOPLFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPLConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label OPLStructureLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ListView GamesListView;
        private System.Windows.Forms.ToolStripMenuItem refreshOPLFolderToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader GameName;
        private System.Windows.Forms.ColumnHeader DiscType;
        private System.Windows.Forms.ColumnHeader GameID;
        private System.Windows.Forms.ToolStripStatusLabel FolderStatusLabel;
        private System.Windows.Forms.ColumnHeader GameRegion;
        private System.Windows.Forms.ColumnHeader VolumeName;
        private System.Windows.Forms.ColumnHeader GameSize;
        private System.Windows.Forms.ToolStripMenuItem addGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar MainProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel ProgressPercentageLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCopyProgressDialogToolStripMenuItem;
    }
}

