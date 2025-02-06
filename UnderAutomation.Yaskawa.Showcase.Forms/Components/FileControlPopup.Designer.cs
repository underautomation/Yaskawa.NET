
    partial class FileControlPopup
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.tsFolder = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tsFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 25);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(691, 300);
            this.txtContent.TabIndex = 0;
            this.txtContent.WordWrap = false;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 68);
            this.panel1.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Image = global::UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.download_2_line;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(267, 17);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(154, 35);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send changes to robot";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tsFolder
            // 
            this.tsFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
            this.tsFolder.Location = new System.Drawing.Point(0, 0);
            this.tsFolder.Name = "tsFolder";
            this.tsFolder.Size = new System.Drawing.Size(691, 25);
            this.tsFolder.TabIndex = 4;
            this.tsFolder.Text = "ToolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.save_3_fill;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 22);
            this.btnSave.Text = "Save as...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "All files|*.*";
            this.dlgSave.RestoreDirectory = true;
            this.dlgSave.Title = "Download file";
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // FileControlPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.tsFolder);
            this.Controls.Add(this.panel1);
            this.Name = "FileControlPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "---";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.tsFolder.ResumeLayout(false);
            this.tsFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ToolStrip tsFolder;
        internal System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.Button btnSend;
    internal System.Windows.Forms.SaveFileDialog dlgSave;
    private System.Windows.Forms.Timer tmr;
}