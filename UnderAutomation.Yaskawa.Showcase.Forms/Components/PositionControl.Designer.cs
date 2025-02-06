
partial class PositionControl
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
            this.gridJoints = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCartesian = new System.Windows.Forms.PropertyGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.gridError = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // worker
            // 
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // gridJoints
            // 
            this.gridJoints.HelpVisible = false;
            this.gridJoints.Location = new System.Drawing.Point(18, 27);
            this.gridJoints.Name = "gridJoints";
            this.gridJoints.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridJoints.Size = new System.Drawing.Size(228, 571);
            this.gridJoints.TabIndex = 25;
            this.gridJoints.ToolbarVisible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Joints position :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cartesian position :";
            // 
            // gridCartesian
            // 
            this.gridCartesian.HelpVisible = false;
            this.gridCartesian.Location = new System.Drawing.Point(264, 27);
            this.gridCartesian.Name = "gridCartesian";
            this.gridCartesian.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridCartesian.Size = new System.Drawing.Size(228, 571);
            this.gridCartesian.TabIndex = 25;
            this.gridCartesian.ToolbarVisible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Poisition error :";
            // 
            // gridError
            // 
            this.gridError.HelpVisible = false;
            this.gridError.Location = new System.Drawing.Point(507, 27);
            this.gridError.Name = "gridError";
            this.gridError.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridError.Size = new System.Drawing.Size(228, 571);
            this.gridError.TabIndex = 25;
            this.gridError.ToolbarVisible = false;
            // 
            // PositionControl
            // 
            this.Controls.Add(this.gridError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridCartesian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridJoints);
            this.Controls.Add(this.label2);
            this.Name = "PositionControl";
            this.Size = new System.Drawing.Size(793, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.ComponentModel.BackgroundWorker worker;
    private System.Windows.Forms.PropertyGrid gridJoints;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PropertyGrid gridCartesian;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PropertyGrid gridError;
}
