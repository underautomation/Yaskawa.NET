
partial class ParametersControl
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
        btnReadParameter = new Button();
        txtValue = new TextBox();
        label1 = new Label();
        nudGroup = new NumericUpDown();
        label5 = new Label();
        label3 = new Label();
        nudIndex = new NumericUpDown();
        label4 = new Label();
        cbType = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)nudGroup).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudIndex).BeginInit();
        SuspendLayout();
        // 
        // btnReadParameter
        // 
        btnReadParameter.Location = new Point(119, 133);
        btnReadParameter.Name = "btnReadParameter";
        btnReadParameter.Size = new Size(144, 23);
        btnReadParameter.TabIndex = 0;
        btnReadParameter.Text = "Read parameter";
        btnReadParameter.UseVisualStyleBackColor = true;
        btnReadParameter.Click += btnReadParameter_Click;
        // 
        // txtValue
        // 
        txtValue.Location = new Point(119, 175);
        txtValue.Name = "txtValue";
        txtValue.ReadOnly = true;
        txtValue.Size = new Size(144, 23);
        txtValue.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new Point(55, 175);
        label1.Name = "label1";
        label1.Size = new Size(58, 23);
        label1.TabIndex = 2;
        label1.Text = "Value:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudGroup
        // 
        nudGroup.Location = new Point(119, 85);
        nudGroup.Name = "nudGroup";
        nudGroup.Size = new Size(144, 23);
        nudGroup.TabIndex = 3;
        nudGroup.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label5
        // 
        label5.Location = new Point(55, 85);
        label5.Name = "label5";
        label5.Size = new Size(58, 23);
        label5.TabIndex = 2;
        label5.Text = "Group:";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        label3.Location = new Point(55, 58);
        label3.Name = "label3";
        label3.Size = new Size(58, 21);
        label3.TabIndex = 2;
        label3.Text = "Index:";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudIndex
        // 
        nudIndex.Location = new Point(119, 56);
        nudIndex.Name = "nudIndex";
        nudIndex.Size = new Size(144, 23);
        nudIndex.TabIndex = 3;
        // 
        // label4
        // 
        label4.Location = new Point(55, 22);
        label4.Name = "label4";
        label4.Size = new Size(58, 23);
        label4.TabIndex = 2;
        label4.Text = "Type:";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cbType
        // 
        cbType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbType.FormattingEnabled = true;
        cbType.Location = new Point(119, 22);
        cbType.Name = "cbType";
        cbType.Size = new Size(144, 23);
        cbType.TabIndex = 4;
        cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
        // 
        // ParametersControl
        // 
        Controls.Add(cbType);
        Controls.Add(nudIndex);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(nudGroup);
        Controls.Add(label5);
        Controls.Add(label1);
        Controls.Add(txtValue);
        Controls.Add(btnReadParameter);
        Name = "ParametersControl";
        Size = new Size(593, 418);
        ((System.ComponentModel.ISupportInitialize)nudGroup).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudIndex).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnReadParameter;
    private TextBox txtValue;
    private Label label1;
    private NumericUpDown nudGroup;
    private Label label5;
    private Label label3;
    private NumericUpDown nudIndex;
    private Label label4;
    private ComboBox cbType;
}
