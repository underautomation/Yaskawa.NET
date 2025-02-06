
partial class JobControl
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
            this.gridExecuting = new System.Windows.Forms.PropertyGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.gridStatus = new System.Windows.Forms.PropertyGrid();
            this.udJobLine = new System.Windows.Forms.NumericUpDown();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbJobs = new System.Windows.Forms.ComboBox();
            this.txtJobLine = new System.Windows.Forms.Label();
            this.txtJobList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnServoOff = new System.Windows.Forms.Button();
            this.btnServoOn = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.udJobLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExecuting
            // 
            this.gridExecuting.HelpVisible = false;
            this.gridExecuting.Location = new System.Drawing.Point(28, 314);
            this.gridExecuting.Name = "gridExecuting";
            this.gridExecuting.Size = new System.Drawing.Size(276, 93);
            this.gridExecuting.TabIndex = 18;
            this.gridExecuting.ToolbarVisible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Executing job :";
            // 
            // gridStatus
            // 
            this.gridStatus.HelpVisible = false;
            this.gridStatus.Location = new System.Drawing.Point(28, 32);
            this.gridStatus.Name = "gridStatus";
            this.gridStatus.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridStatus.Size = new System.Drawing.Size(276, 247);
            this.gridStatus.TabIndex = 19;
            this.gridStatus.ToolbarVisible = false;
            // 
            // udJobLine
            // 
            this.udJobLine.Location = new System.Drawing.Point(94, 148);
            this.udJobLine.Name = "udJobLine";
            this.udJobLine.Size = new System.Drawing.Size(55, 20);
            this.udJobLine.TabIndex = 11;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(19, 193);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(266, 35);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select job";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(218, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbJobs
            // 
            this.cbJobs.FormattingEnabled = true;
            this.cbJobs.Location = new System.Drawing.Point(19, 109);
            this.cbJobs.Name = "cbJobs";
            this.cbJobs.Size = new System.Drawing.Size(192, 21);
            this.cbJobs.TabIndex = 0;
            // 
            // txtJobLine
            // 
            this.txtJobLine.AutoSize = true;
            this.txtJobLine.Location = new System.Drawing.Point(16, 150);
            this.txtJobLine.Name = "txtJobLine";
            this.txtJobLine.Size = new System.Drawing.Size(72, 13);
            this.txtJobLine.TabIndex = 9;
            this.txtJobLine.Text = "Job start line :";
            // 
            // txtJobList
            // 
            this.txtJobList.AutoSize = true;
            this.txtJobList.Location = new System.Drawing.Point(16, 93);
            this.txtJobList.Name = "txtJobList";
            this.txtJobList.Size = new System.Drawing.Size(69, 13);
            this.txtJobList.TabIndex = 9;
            this.txtJobList.Text = "Select a job :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "System status :";
            // 
            // btnServoOff
            // 
            this.btnServoOff.Location = new System.Drawing.Point(155, 23);
            this.btnServoOff.Name = "btnServoOff";
            this.btnServoOff.Size = new System.Drawing.Size(130, 35);
            this.btnServoOff.TabIndex = 11;
            this.btnServoOff.Text = "Servo OFF";
            this.btnServoOff.UseVisualStyleBackColor = true;
            this.btnServoOff.Click += new System.EventHandler(this.btnServoOff_Click);
            // 
            // btnServoOn
            // 
            this.btnServoOn.Location = new System.Drawing.Point(19, 23);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(130, 35);
            this.btnServoOn.TabIndex = 11;
            this.btnServoOn.Text = "Servo ON";
            this.btnServoOn.UseVisualStyleBackColor = true;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 260);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(265, 35);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start selected job";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnServoOn);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtJobList);
            this.panel1.Controls.Add(this.udJobLine);
            this.panel1.Controls.Add(this.txtJobLine);
            this.panel1.Controls.Add(this.btnServoOff);
            this.panel1.Controls.Add(this.cbJobs);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(340, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 375);
            this.panel1.TabIndex = 20;
            // 
            // JobControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridExecuting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridStatus);
            this.Controls.Add(this.label2);
            this.Name = "JobControl";
            this.Size = new System.Drawing.Size(910, 743);
            ((System.ComponentModel.ISupportInitialize)(this.udJobLine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PropertyGrid gridExecuting;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PropertyGrid gridStatus;
    private System.Windows.Forms.NumericUpDown udJobLine;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.ComboBox cbJobs;
    private System.Windows.Forms.Label txtJobLine;
    private System.Windows.Forms.Label txtJobList;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnServoOff;
    private System.Windows.Forms.Button btnServoOn;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Panel panel1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
}
