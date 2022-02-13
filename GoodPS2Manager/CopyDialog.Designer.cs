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
            this.GameCopyList = new System.Windows.Forms.ListView();
            this.SourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProgressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddImagesButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StartCopyButton = new System.Windows.Forms.Button();
            this.OverallCopyProgressBar = new System.Windows.Forms.ProgressBar();
            this.RemoveImagesButton = new System.Windows.Forms.Button();
            this.CancelCopyButton = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvSource = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvProgress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameCopyList
            // 
            this.GameCopyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SourceColumn,
            this.StatusColumn,
            this.ProgressColumn});
            this.GameCopyList.FullRowSelect = true;
            this.GameCopyList.GridLines = true;
            this.GameCopyList.HideSelection = false;
            this.GameCopyList.Location = new System.Drawing.Point(628, 320);
            this.GameCopyList.Margin = new System.Windows.Forms.Padding(2);
            this.GameCopyList.Name = "GameCopyList";
            this.GameCopyList.Size = new System.Drawing.Size(144, 113);
            this.GameCopyList.TabIndex = 0;
            this.GameCopyList.UseCompatibleStateImageBehavior = false;
            this.GameCopyList.View = System.Windows.Forms.View.Details;
            this.GameCopyList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.GameCopyList_ItemSelectionChanged);
            // 
            // SourceColumn
            // 
            this.SourceColumn.Text = "Source";
            this.SourceColumn.Width = 614;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 265;
            // 
            // ProgressColumn
            // 
            this.ProgressColumn.Text = "Progress";
            this.ProgressColumn.Width = 260;
            // 
            // AddImagesButton
            // 
            this.AddImagesButton.Location = new System.Drawing.Point(8, 485);
            this.AddImagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddImagesButton.Name = "AddImagesButton";
            this.AddImagesButton.Size = new System.Drawing.Size(100, 26);
            this.AddImagesButton.TabIndex = 1;
            this.AddImagesButton.Text = "Add Images";
            this.AddImagesButton.UseVisualStyleBackColor = true;
            this.AddImagesButton.Click += new System.EventHandler(this.AddImagesButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(671, 485);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 26);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StartCopyButton
            // 
            this.StartCopyButton.Enabled = false;
            this.StartCopyButton.Location = new System.Drawing.Point(567, 485);
            this.StartCopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartCopyButton.Name = "StartCopyButton";
            this.StartCopyButton.Size = new System.Drawing.Size(100, 26);
            this.StartCopyButton.TabIndex = 1;
            this.StartCopyButton.Text = "Start Copy";
            this.StartCopyButton.UseVisualStyleBackColor = true;
            this.StartCopyButton.Click += new System.EventHandler(this.StartCopyButton_Click);
            // 
            // OverallCopyProgressBar
            // 
            this.OverallCopyProgressBar.Location = new System.Drawing.Point(9, 466);
            this.OverallCopyProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.OverallCopyProgressBar.Name = "OverallCopyProgressBar";
            this.OverallCopyProgressBar.Size = new System.Drawing.Size(763, 15);
            this.OverallCopyProgressBar.Step = 1;
            this.OverallCopyProgressBar.TabIndex = 2;
            // 
            // RemoveImagesButton
            // 
            this.RemoveImagesButton.Enabled = false;
            this.RemoveImagesButton.Location = new System.Drawing.Point(112, 485);
            this.RemoveImagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveImagesButton.Name = "RemoveImagesButton";
            this.RemoveImagesButton.Size = new System.Drawing.Size(100, 26);
            this.RemoveImagesButton.TabIndex = 1;
            this.RemoveImagesButton.Text = "Remove Images";
            this.RemoveImagesButton.UseVisualStyleBackColor = true;
            this.RemoveImagesButton.Click += new System.EventHandler(this.RemoveImagesButton_Click);
            // 
            // CancelCopyButton
            // 
            this.CancelCopyButton.Enabled = false;
            this.CancelCopyButton.Location = new System.Drawing.Point(463, 485);
            this.CancelCopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelCopyButton.Name = "CancelCopyButton";
            this.CancelCopyButton.Size = new System.Drawing.Size(100, 26);
            this.CancelCopyButton.TabIndex = 1;
            this.CancelCopyButton.Text = "Cancel Copy";
            this.CancelCopyButton.UseVisualStyleBackColor = true;
            this.CancelCopyButton.Click += new System.EventHandler(this.CancelCopyButton_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvSource);
            this.objectListView1.AllColumns.Add(this.olvStatus);
            this.objectListView1.AllColumns.Add(this.olvProgress);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvSource,
            this.olvStatus,
            this.olvProgress});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(12, 12);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(541, 449);
            this.objectListView1.TabIndex = 3;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvSource
            // 
            this.olvSource.AspectName = "Source";
            this.olvSource.Text = "Source";
            this.olvSource.Width = 247;
            // 
            // olvStatus
            // 
            this.olvStatus.AspectName = "Status";
            this.olvStatus.Text = "Status";
            // 
            // olvProgress
            // 
            this.olvProgress.AspectName = "Progress";
            this.olvProgress.Text = "Progress";
            // 
            // CopyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 519);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.OverallCopyProgressBar);
            this.Controls.Add(this.CancelCopyButton);
            this.Controls.Add(this.StartCopyButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RemoveImagesButton);
            this.Controls.Add(this.AddImagesButton);
            this.Controls.Add(this.GameCopyList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CopyDialog";
            this.Text = "Add Games";
            this.Load += new System.EventHandler(this.CopyDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView GameCopyList;
        private System.Windows.Forms.ColumnHeader SourceColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.ColumnHeader ProgressColumn;
        private System.Windows.Forms.Button AddImagesButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StartCopyButton;
        private System.Windows.Forms.ProgressBar OverallCopyProgressBar;
        private System.Windows.Forms.Button RemoveImagesButton;
        private System.Windows.Forms.Button CancelCopyButton;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvSource;
        private BrightIdeasSoftware.OLVColumn olvStatus;
        private BrightIdeasSoftware.OLVColumn olvProgress;
    }
}