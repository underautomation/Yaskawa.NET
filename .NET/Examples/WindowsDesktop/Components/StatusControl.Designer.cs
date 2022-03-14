
partial class StatusControl
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
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.gridExecuting = new System.Windows.Forms.PropertyGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.gridStatus = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTime = new System.Windows.Forms.PropertyGrid();
            this.gridInfo = new System.Windows.Forms.PropertyGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // worker
            // 
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // gridExecuting
            // 
            this.gridExecuting.HelpVisible = false;
            this.gridExecuting.Location = new System.Drawing.Point(18, 319);
            this.gridExecuting.Name = "gridExecuting";
            this.gridExecuting.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridExecuting.Size = new System.Drawing.Size(276, 96);
            this.gridExecuting.TabIndex = 22;
            this.gridExecuting.ToolbarVisible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Executing job :";
            // 
            // gridStatus
            // 
            this.gridStatus.HelpVisible = false;
            this.gridStatus.Location = new System.Drawing.Point(18, 29);
            this.gridStatus.Name = "gridStatus";
            this.gridStatus.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridStatus.Size = new System.Drawing.Size(276, 245);
            this.gridStatus.TabIndex = 23;
            this.gridStatus.ToolbarVisible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "System status :";
            // 
            // gridTime
            // 
            this.gridTime.HelpVisible = false;
            this.gridTime.Location = new System.Drawing.Point(323, 29);
            this.gridTime.Name = "gridTime";
            this.gridTime.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridTime.Size = new System.Drawing.Size(316, 487);
            this.gridTime.TabIndex = 26;
            this.gridTime.ToolbarVisible = false;
            // 
            // gridInfo
            // 
            this.gridInfo.HelpVisible = false;
            this.gridInfo.Location = new System.Drawing.Point(20, 447);
            this.gridInfo.Name = "gridInfo";
            this.gridInfo.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridInfo.Size = new System.Drawing.Size(274, 69);
            this.gridInfo.TabIndex = 27;
            this.gridInfo.ToolbarVisible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Management time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "System information :";
            // 
            // StatusControl
            // 
            this.Controls.Add(this.gridTime);
            this.Controls.Add(this.gridInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridExecuting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridStatus);
            this.Controls.Add(this.label2);
            this.Name = "StatusControl";
            this.Size = new System.Drawing.Size(797, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.ComponentModel.BackgroundWorker worker;
    private System.Windows.Forms.PropertyGrid gridExecuting;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PropertyGrid gridStatus;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PropertyGrid gridTime;
    private System.Windows.Forms.PropertyGrid gridInfo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
}
