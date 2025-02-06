
partial class PendantControl
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPopup = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 16);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(350, 150);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.Text = "This is a message to display on pendant !";
            // 
            // btnPopup
            // 
            this.btnPopup.Location = new System.Drawing.Point(12, 181);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(350, 35);
            this.btnPopup.TabIndex = 11;
            this.btnPopup.Text = "Display message";
            this.btnPopup.UseVisualStyleBackColor = true;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(396, 44);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(130, 35);
            this.btnLock.TabIndex = 11;
            this.btnLock.Text = "Lock pendant";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(396, 95);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(130, 35);
            this.btnUnlock.TabIndex = 11;
            this.btnUnlock.Text = "Unlock pendant";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // PendantControl
            // 
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Name = "PendantControl";
            this.Size = new System.Drawing.Size(593, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.Button btnPopup;
    private System.Windows.Forms.Button btnLock;
    private System.Windows.Forms.Button btnUnlock;
}
