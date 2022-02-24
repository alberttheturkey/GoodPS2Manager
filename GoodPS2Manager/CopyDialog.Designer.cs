namespace GoodPS2Manager
{
    partial class CopyDialog
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
            this.AddImagesButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StartCopyButton = new System.Windows.Forms.Button();
            this.OverallCopyProgressBar = new System.Windows.Forms.ProgressBar();
            this.RemoveImagesButton = new System.Windows.Forms.Button();
            this.CancelCopyButton = new System.Windows.Forms.Button();
            this.CopyJobList = new BrightIdeasSoftware.ObjectListView();
            this.olvSource = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvProgress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.CopyJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddImagesButton
            // 
            this.AddImagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddImagesButton.Location = new System.Drawing.Point(8, 485);
            this.AddImagesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddImagesButton.Name = "AddImagesButton";
            this.AddImagesButton.Size = new System.Drawing.Size(100, 26);
            this.AddImagesButton.TabIndex = 1;
            this.AddImagesButton.Text = "Add Images";
            this.AddImagesButton.UseVisualStyleBackColor = true;
            this.AddImagesButton.Click += new System.EventHandler(this.AddImagesButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(671, 485);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 26);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StartCopyButton
            // 
            this.StartCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCopyButton.Enabled = false;
            this.StartCopyButton.Location = new System.Drawing.Point(567, 485);
            this.StartCopyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartCopyButton.Name = "StartCopyButton";
            this.StartCopyButton.Size = new System.Drawing.Size(100, 26);
            this.StartCopyButton.TabIndex = 1;
            this.StartCopyButton.Text = "Start Copy";
            this.StartCopyButton.UseVisualStyleBackColor = true;
            this.StartCopyButton.Click += new System.EventHandler(this.StartCopyButton_Click);
            // 
            // OverallCopyProgressBar
            // 
            this.OverallCopyProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverallCopyProgressBar.Location = new System.Drawing.Point(9, 466);
            this.OverallCopyProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OverallCopyProgressBar.Name = "OverallCopyProgressBar";
            this.OverallCopyProgressBar.Size = new System.Drawing.Size(763, 15);
            this.OverallCopyProgressBar.Step = 1;
            this.OverallCopyProgressBar.TabIndex = 2;
            // 
            // RemoveImagesButton
            // 
            this.RemoveImagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveImagesButton.Enabled = false;
            this.RemoveImagesButton.Location = new System.Drawing.Point(112, 485);
            this.RemoveImagesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveImagesButton.Name = "RemoveImagesButton";
            this.RemoveImagesButton.Size = new System.Drawing.Size(100, 26);
            this.RemoveImagesButton.TabIndex = 1;
            this.RemoveImagesButton.Text = "Remove Images";
            this.RemoveImagesButton.UseVisualStyleBackColor = true;
            this.RemoveImagesButton.Click += new System.EventHandler(this.RemoveImagesButton_Click);
            // 
            // CancelCopyButton
            // 
            this.CancelCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelCopyButton.Enabled = false;
            this.CancelCopyButton.Location = new System.Drawing.Point(463, 485);
            this.CancelCopyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelCopyButton.Name = "CancelCopyButton";
            this.CancelCopyButton.Size = new System.Drawing.Size(100, 26);
            this.CancelCopyButton.TabIndex = 1;
            this.CancelCopyButton.Text = "Cancel Copy";
            this.CancelCopyButton.UseVisualStyleBackColor = true;
            this.CancelCopyButton.Click += new System.EventHandler(this.CancelCopyButton_Click);
            // 
            // CopyJobList
            // 
            this.CopyJobList.AllColumns.Add(this.olvSource);
            this.CopyJobList.AllColumns.Add(this.olvStatus);
            this.CopyJobList.AllColumns.Add(this.olvProgress);
            this.CopyJobList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyJobList.CellEditUseWholeCell = false;
            this.CopyJobList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvSource,
            this.olvStatus,
            this.olvProgress});
            this.CopyJobList.Cursor = System.Windows.Forms.Cursors.Default;
            this.CopyJobList.FullRowSelect = true;
            this.CopyJobList.HasCollapsibleGroups = false;
            this.CopyJobList.HideSelection = false;
            this.CopyJobList.Location = new System.Drawing.Point(12, 12);
            this.CopyJobList.Name = "CopyJobList";
            this.CopyJobList.ShowGroups = false;
            this.CopyJobList.Size = new System.Drawing.Size(755, 449);
            this.CopyJobList.SortGroupItemsByPrimaryColumn = false;
            this.CopyJobList.TabIndex = 3;
            this.CopyJobList.UseCompatibleStateImageBehavior = false;
            this.CopyJobList.UseNotifyPropertyChanged = true;
            this.CopyJobList.View = System.Windows.Forms.View.Details;
            this.CopyJobList.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.CopyJobList_ItemsChanged);
            this.CopyJobList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopyJobList_KeyUp);
            // 
            // olvSource
            // 
            this.olvSource.AspectName = "Source";
            this.olvSource.Text = "Source";
            this.olvSource.Width = 478;
            // 
            // olvStatus
            // 
            this.olvStatus.AspectName = "StatusDisplay";
            this.olvStatus.Text = "Status";
            this.olvStatus.Width = 104;
            // 
            // olvProgress
            // 
            this.olvProgress.AspectName = "Progress";
            this.olvProgress.Groupable = false;
            this.olvProgress.Text = "Progress";
            // 
            // CopyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 519);
            this.Controls.Add(this.CopyJobList);
            this.Controls.Add(this.OverallCopyProgressBar);
            this.Controls.Add(this.CancelCopyButton);
            this.Controls.Add(this.StartCopyButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RemoveImagesButton);
            this.Controls.Add(this.AddImagesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CopyDialog";
            this.Text = "Add Games";
            ((System.ComponentModel.ISupportInitialize)(this.CopyJobList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddImagesButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StartCopyButton;
        private System.Windows.Forms.ProgressBar OverallCopyProgressBar;
        private System.Windows.Forms.Button RemoveImagesButton;
        private System.Windows.Forms.Button CancelCopyButton;
        private BrightIdeasSoftware.ObjectListView CopyJobList;
        private BrightIdeasSoftware.OLVColumn olvSource;
        private BrightIdeasSoftware.OLVColumn olvStatus;
        private BrightIdeasSoftware.OLVColumn olvProgress;
    }
}