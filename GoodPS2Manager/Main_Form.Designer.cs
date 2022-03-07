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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodPS2Manger_Main_Form));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCopyProgressDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cleanFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discImageUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.artDownloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftHandSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightHandSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOPLFolderButton = new System.Windows.Forms.Button();
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
            this.createOPLFolderToolStripMenuItem,
            this.openOPLFolderToolStripMenuItem,
            this.recentOPLFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.addGamesToolStripMenuItem,
            this.toolStripSeparator2,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createOPLFolderToolStripMenuItem
            // 
            this.createOPLFolderToolStripMenuItem.Name = "createOPLFolderToolStripMenuItem";
            this.createOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.createOPLFolderToolStripMenuItem.Text = "Create OPL Folder";
            this.createOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.createOPLFolderToolStripMenuItem_Click);
            // 
            // openOPLFolderToolStripMenuItem
            // 
            this.openOPLFolderToolStripMenuItem.Name = "openOPLFolderToolStripMenuItem";
            this.openOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.openOPLFolderToolStripMenuItem.Text = "Open OPL Folder";
            this.openOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.openOPLFolderToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshOPLFolderToolStripMenuItem,
            this.cleanFilesToolStripMenuItem,
            this.toolStripSeparator3,
            this.discImageUtilityToolStripMenuItem,
            this.toolStripSeparator4,
            this.artDownloaderToolStripMenuItem});
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
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCopyProgressDialogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sidebarToolStripMenuItem});
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.aboutToolStripMenuItem.Text = "About Good PS2 Manager *";
            // 
            // OPLStructureLabel
            // 
            this.OPLStructureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OPLStructureLabel.AutoSize = true;
            this.OPLStructureLabel.Location = new System.Drawing.Point(1533, 36);
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
            this.GamesListView.Location = new System.Drawing.Point(12, 36);
            this.GamesListView.Name = "GamesListView";
            this.GamesListView.Size = new System.Drawing.Size(1515, 882);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // recentOPLFolderToolStripMenuItem
            // 
            this.recentOPLFolderToolStripMenuItem.Name = "recentOPLFolderToolStripMenuItem";
            this.recentOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.recentOPLFolderToolStripMenuItem.Text = "Recent OPL Folder *";
            // 
            // addGamesToolStripMenuItem
            // 
            this.addGamesToolStripMenuItem.Enabled = false;
            this.addGamesToolStripMenuItem.Name = "addGamesToolStripMenuItem";
            this.addGamesToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.addGamesToolStripMenuItem.Text = "Add Games";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(268, 6);
            // 
            // cleanFilesToolStripMenuItem
            // 
            this.cleanFilesToolStripMenuItem.Name = "cleanFilesToolStripMenuItem";
            this.cleanFilesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cleanFilesToolStripMenuItem.Text = "Clean Files *";
            // 
            // discImageUtilityToolStripMenuItem
            // 
            this.discImageUtilityToolStripMenuItem.Name = "discImageUtilityToolStripMenuItem";
            this.discImageUtilityToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.discImageUtilityToolStripMenuItem.Text = "Disc Image Utility *";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // artDownloaderToolStripMenuItem
            // 
            this.artDownloaderToolStripMenuItem.Name = "artDownloaderToolStripMenuItem";
            this.artDownloaderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.artDownloaderToolStripMenuItem.Text = "Art Downloader *";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(336, 34);
            this.toolStripMenuItem1.Text = "Show Status Bar *";
            // 
            // sidebarToolStripMenuItem
            // 
            this.sidebarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftHandSideToolStripMenuItem,
            this.rightHandSideToolStripMenuItem,
            this.toolStripSeparator5,
            this.hideToolStripMenuItem});
            this.sidebarToolStripMenuItem.Name = "sidebarToolStripMenuItem";
            this.sidebarToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.sidebarToolStripMenuItem.Text = "Sidebar *";
            // 
            // leftHandSideToolStripMenuItem
            // 
            this.leftHandSideToolStripMenuItem.CheckOnClick = true;
            this.leftHandSideToolStripMenuItem.Name = "leftHandSideToolStripMenuItem";
            this.leftHandSideToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.leftHandSideToolStripMenuItem.Text = "Left Hand Side";
            // 
            // rightHandSideToolStripMenuItem
            // 
            this.rightHandSideToolStripMenuItem.CheckOnClick = true;
            this.rightHandSideToolStripMenuItem.Name = "rightHandSideToolStripMenuItem";
            this.rightHandSideToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rightHandSideToolStripMenuItem.Text = "Right Hand Side";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.CheckOnClick = true;
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hideToolStripMenuItem.Text = "Hide";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.gitHubToolStripMenuItem.Text = "GitHub *";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates *";
            // 
            // OpenOPLFolderButton
            // 
            this.OpenOPLFolderButton.Location = new System.Drawing.Point(1537, 888);
            this.OpenOPLFolderButton.Name = "OpenOPLFolderButton";
            this.OpenOPLFolderButton.Size = new System.Drawing.Size(283, 30);
            this.OpenOPLFolderButton.TabIndex = 4;
            this.OpenOPLFolderButton.Text = "Open OPL Folder";
            this.OpenOPLFolderButton.UseVisualStyleBackColor = true;
            this.OpenOPLFolderButton.Click += new System.EventHandler(this.OpenOPLFolderButton_Click);
            // 
            // GoodPS2Manger_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 962);
            this.Controls.Add(this.OpenOPLFolderButton);
            this.Controls.Add(this.GamesListView);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.OPLStructureLabel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(994, 982);
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
        private System.Windows.Forms.ToolStripProgressBar MainProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel ProgressPercentageLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCopyProgressDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOPLFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentOPLFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cleanFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discImageUtilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem artDownloaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sidebarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftHandSideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightHandSideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Button OpenOPLFolderButton;
    }
}

