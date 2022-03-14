
    partial class FileControl
{
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileControl));
            this.lstFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.lstFolder = new System.Windows.Forms.ListView();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbPattern = new System.Windows.Forms.ToolStripComboBox();
            this.btnOpenPath = new System.Windows.Forms.ToolStripButton();
            this.tsFolder = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.lblProgress = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            this.tsFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFolderImageList
            // 
            this.lstFolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstFolderImageList.ImageStream")));
            this.lstFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.lstFolderImageList.Images.SetKeyName(0, "folder");
            this.lstFolderImageList.Images.SetKeyName(1, "file");
            this.lstFolderImageList.Images.SetKeyName(2, "symbolicLink");
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "All files|*.*";
            this.dlgOpen.Title = "Select file to upload";
            // 
            // lstFolder
            // 
            this.lstFolder.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lstFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFolder.HideSelection = false;
            this.lstFolder.LabelEdit = true;
            this.lstFolder.LargeImageList = this.lstFolderImageList;
            this.lstFolder.Location = new System.Drawing.Point(0, 50);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(980, 612);
            this.lstFolder.TabIndex = 4;
            this.lstFolder.UseCompatibleStateImageBehavior = false;
            this.lstFolder.ItemActivate += new System.EventHandler(this.lstFolder_ItemActivate);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbPattern,
            this.btnOpenPath});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(980, 25);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel1.Text = "Pattern :";
            // 
            // cbPattern
            // 
            this.cbPattern.Items.AddRange(new object[] {
            "*.JBI",
            "*.PRM",
            "*.DAT",
            "*.CND",
            "*.SYS",
            "*.LST",
            "*.CSV",
            "*.LOG",
            "*.TXT",
            "*.JOB"});
            this.cbPattern.Name = "cbPattern";
            this.cbPattern.Size = new System.Drawing.Size(121, 25);
            this.cbPattern.Text = "*.JBI";
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenPath.Image = global::UnderAutomation.Yaskawa.Sample.WindowsDesktop.Properties.Resources.arrow_right_line;
            this.btnOpenPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(23, 22);
            this.btnOpenPath.Text = "Open";
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // tsFolder
            // 
            this.tsFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnOpen,
            this.btnDownload,
            this.btnDelete,
            this.btnUpload});
            this.tsFolder.Location = new System.Drawing.Point(0, 0);
            this.tsFolder.Name = "tsFolder";
            this.tsFolder.Size = new System.Drawing.Size(980, 25);
            this.tsFolder.TabIndex = 3;
            this.tsFolder.Text = "ToolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::UnderAutomation.Yaskawa.Sample.WindowsDesktop.Properties.Resources.refresh_line;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::UnderAutomation.Yaskawa.Sample.WindowsDesktop.Properties.Resources.file_edit_line;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(47, 22);
            this.btnOpen.Text = "Edit";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Image = global::UnderAutomation.Yaskawa.Sample.WindowsDesktop.Properties.Resources.save_3_fill;
            this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(102, 22);
            this.btnDownload.Text = "Download File";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::UnderAutomation.Yaskawa.Sample.WindowsDesktop.Properties.Resources.delete_bin_5_line;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::UnderAutomation.Yaskawa.Sample.WindowsDesktop.Properties.Resources.upload_2_line;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(84, 22);
            this.btnUpload.Text = "Upload file";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProgress.Location = new System.Drawing.Point(301, 73);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(277, 145);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "...";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgress.Visible = false;
            // 
            // FileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lstFolder);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.tsFolder);
            this.Name = "FileControl";
            this.Size = new System.Drawing.Size(980, 662);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.tsFolder.ResumeLayout(false);
            this.tsFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    internal System.Windows.Forms.ImageList lstFolderImageList;
    internal System.Windows.Forms.ListView lstFolder;
    internal System.Windows.Forms.ToolStrip ToolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripComboBox cbPattern;
    internal System.Windows.Forms.ToolStripButton btnOpenPath;
    internal System.Windows.Forms.ToolStrip tsFolder;
    internal System.Windows.Forms.ToolStripButton btnRefresh;
    internal System.Windows.Forms.ToolStripButton btnOpen;
    internal System.Windows.Forms.ToolStripButton btnDelete;
    internal System.Windows.Forms.ToolStripButton btnUpload;
    internal System.Windows.Forms.ToolStripButton btnDownload;
    private System.Windows.Forms.Label lblProgress;
}
