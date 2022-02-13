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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPLConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPLStructureLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FolderStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GamesListView = new System.Windows.Forms.ListView();
            this.GameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiscType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VolumeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createOPLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOPLFolderToolStripMenuItem,
            this.openOPLFolderToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openOPLFolderToolStripMenuItem
            // 
            this.openOPLFolderToolStripMenuItem.Name = "openOPLFolderToolStripMenuItem";
            this.openOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openOPLFolderToolStripMenuItem.Text = "Open OPL Folder";
            this.openOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.openOPLFolderToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshOPLFolderToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // refreshOPLFolderToolStripMenuItem
            // 
            this.refreshOPLFolderToolStripMenuItem.Name = "refreshOPLFolderToolStripMenuItem";
            this.refreshOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.refreshOPLFolderToolStripMenuItem.Text = "Refresh OPL Folder";
            this.refreshOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.refreshOPLFolderToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPLConfigToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // oPLConfigToolStripMenuItem
            // 
            this.oPLConfigToolStripMenuItem.Name = "oPLConfigToolStripMenuItem";
            this.oPLConfigToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.oPLConfigToolStripMenuItem.Text = "OPL Config";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OPLStructureLabel
            // 
            this.OPLStructureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OPLStructureLabel.AutoSize = true;
            this.OPLStructureLabel.Location = new System.Drawing.Point(953, 23);
            this.OPLStructureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OPLStructureLabel.Name = "OPLStructureLabel";
            this.OPLStructureLabel.Size = new System.Drawing.Size(83, 13);
            this.OPLStructureLabel.TabIndex = 1;
            this.OPLStructureLabel.Text = "Nothing Loaded";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1221, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FolderStatusLabel
            // 
            this.FolderStatusLabel.Name = "FolderStatusLabel";
            this.FolderStatusLabel.Size = new System.Drawing.Size(121, 17);
            this.FolderStatusLabel.Text = "No OPL folder loaded";
            // 
            // GamesListView
            // 
            this.GamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.GamesListView.Location = new System.Drawing.Point(-3, 26);
            this.GamesListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GamesListView.Name = "GamesListView";
            this.GamesListView.Size = new System.Drawing.Size(952, 575);
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
            this.GameID.Width = 54;
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
            // createOPLFolderToolStripMenuItem
            // 
            this.createOPLFolderToolStripMenuItem.Name = "createOPLFolderToolStripMenuItem";
            this.createOPLFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createOPLFolderToolStripMenuItem.Text = "Create OPL Folder";
            this.createOPLFolderToolStripMenuItem.Click += new System.EventHandler(this.createOPLFolderToolStripMenuItem_Click);
            // 
            // GoodPS2Manger_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 625);
            this.Controls.Add(this.GamesListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OPLStructureLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(670, 658);
            this.Name = "GoodPS2Manger_Main_Form";
            this.Text = "Good PS2 Manager Version";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoodPS2Manger_Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.GoodPS2Manger_Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView GamesListView;
        private System.Windows.Forms.ToolStripMenuItem refreshOPLFolderToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader GameName;
        private System.Windows.Forms.ColumnHeader DiscType;
        private System.Windows.Forms.ColumnHeader GameID;
        private System.Windows.Forms.ToolStripStatusLabel FolderStatusLabel;
        private System.Windows.Forms.ColumnHeader GameRegion;
        private System.Windows.Forms.ColumnHeader VolumeName;
        private System.Windows.Forms.ColumnHeader GameSize;
        private System.Windows.Forms.ToolStripMenuItem createOPLFolderToolStripMenuItem;
    }
}

