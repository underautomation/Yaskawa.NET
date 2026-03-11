
partial class ConnectControl
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
        tableLayoutPanel1 = new TableLayoutPanel();
        lblConnected = new Label();
        chkHostControlSerial = new CheckBox();
        label1 = new Label();
        txtIP = new TextBox();
        panel1 = new Panel();
        btnConnect = new Button();
        btnDisconnect = new Button();
        chkHostControlEthernet = new CheckBox();
        lblLicense = new Label();
        chkHSES = new CheckBox();
        lnkConfigureHSES = new LinkLabel();
        label2 = new Label();
        cbComPorts = new ComboBox();
        lnkConfigureHC = new LinkLabel();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(lblConnected, 1, 10);
        tableLayoutPanel1.Controls.Add(chkHostControlSerial, 1, 6);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(txtIP, 1, 0);
        tableLayoutPanel1.Controls.Add(panel1, 1, 9);
        tableLayoutPanel1.Controls.Add(chkHostControlEthernet, 1, 4);
        tableLayoutPanel1.Controls.Add(lblLicense, 2, 9);
        tableLayoutPanel1.Controls.Add(chkHSES, 1, 2);
        tableLayoutPanel1.Controls.Add(lnkConfigureHSES, 2, 2);
        tableLayoutPanel1.Controls.Add(label2, 0, 7);
        tableLayoutPanel1.Controls.Add(cbComPorts, 1, 7);
        tableLayoutPanel1.Controls.Add(lnkConfigureHC, 2, 5);
        tableLayoutPanel1.Location = new Point(21, 32);
        tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 12;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(800, 585);
        tableLayoutPanel1.TabIndex = 10;
        // 
        // lblConnected
        // 
        lblConnected.Dock = DockStyle.Fill;
        lblConnected.Location = new Point(209, 293);
        lblConnected.Margin = new Padding(4, 0, 4, 0);
        lblConnected.Name = "lblConnected";
        lblConnected.Size = new Size(242, 29);
        lblConnected.TabIndex = 19;
        lblConnected.Text = "______";
        lblConnected.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // chkHostControlSerial
        // 
        chkHostControlSerial.Anchor = AnchorStyles.Left;
        chkHostControlSerial.AutoSize = true;
        chkHostControlSerial.Location = new Point(209, 183);
        chkHostControlSerial.Margin = new Padding(4, 3, 4, 3);
        chkHostControlSerial.Name = "chkHostControlSerial";
        chkHostControlSerial.Size = new Size(235, 19);
        chkHostControlSerial.TabIndex = 4;
        chkHostControlSerial.Text = "Enable Host Control (Serial - COM Port)";
        chkHostControlSerial.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Cursor = Cursors.Help;
        label1.Location = new Point(142, 27);
        label1.Margin = new Padding(0);
        label1.Name = "label1";
        label1.Size = new Size(63, 15);
        label1.TabIndex = 0;
        label1.Text = "IP address:";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtIP
        // 
        txtIP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(txtIP, 2);
        txtIP.Cursor = Cursors.Help;
        txtIP.Location = new Point(209, 23);
        txtIP.Margin = new Padding(4, 3, 4, 3);
        txtIP.Name = "txtIP";
        txtIP.Size = new Size(587, 23);
        txtIP.TabIndex = 1;
        txtIP.Text = "192.168.0.1";
        // 
        // panel1
        // 
        panel1.Controls.Add(btnConnect);
        panel1.Controls.Add(btnDisconnect);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(209, 256);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(242, 34);
        panel1.TabIndex = 12;
        // 
        // btnConnect
        // 
        btnConnect.Dock = DockStyle.Left;
        btnConnect.Location = new Point(0, 0);
        btnConnect.Margin = new Padding(4, 3, 4, 3);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(112, 34);
        btnConnect.TabIndex = 17;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // btnDisconnect
        // 
        btnDisconnect.Dock = DockStyle.Right;
        btnDisconnect.Location = new Point(135, 0);
        btnDisconnect.Margin = new Padding(4, 3, 4, 3);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Size = new Size(107, 34);
        btnDisconnect.TabIndex = 18;
        btnDisconnect.Text = "Disconnect";
        btnDisconnect.UseVisualStyleBackColor = true;
        btnDisconnect.Click += btnDisconnect_Click;
        // 
        // chkHostControlEthernet
        // 
        chkHostControlEthernet.Anchor = AnchorStyles.Left;
        chkHostControlEthernet.AutoSize = true;
        chkHostControlEthernet.Location = new Point(209, 137);
        chkHostControlEthernet.Margin = new Padding(4, 3, 4, 3);
        chkHostControlEthernet.Name = "chkHostControlEthernet";
        chkHostControlEthernet.Size = new Size(187, 19);
        chkHostControlEthernet.TabIndex = 4;
        chkHostControlEthernet.Text = "Enable Host Control (Ethernet)";
        chkHostControlEthernet.UseVisualStyleBackColor = true;
        // 
        // lblLicense
        // 
        lblLicense.Anchor = AnchorStyles.Left;
        lblLicense.AutoSize = true;
        lblLicense.Location = new Point(455, 265);
        lblLicense.Margin = new Padding(0);
        lblLicense.Name = "lblLicense";
        lblLicense.Size = new Size(13, 15);
        lblLicense.TabIndex = 25;
        lblLicense.Text = "..";
        // 
        // chkHSES
        // 
        chkHSES.Anchor = AnchorStyles.Left;
        chkHSES.AutoSize = true;
        chkHSES.Location = new Point(209, 91);
        chkHSES.Margin = new Padding(4, 3, 4, 3);
        chkHSES.Name = "chkHSES";
        chkHSES.Size = new Size(207, 19);
        chkHSES.TabIndex = 4;
        chkHSES.Text = "Enable High Speed Ethernet Server";
        chkHSES.UseVisualStyleBackColor = true;
        // 
        // lnkConfigureHSES
        // 
        lnkConfigureHSES.Anchor = AnchorStyles.Left;
        lnkConfigureHSES.AutoSize = true;
        lnkConfigureHSES.Location = new Point(458, 93);
        lnkConfigureHSES.Name = "lnkConfigureHSES";
        lnkConfigureHSES.Size = new Size(208, 15);
        lnkConfigureHSES.TabIndex = 11;
        lnkConfigureHSES.TabStop = true;
        lnkConfigureHSES.Text = "See how to enable High Speed EServer";
        lnkConfigureHSES.LinkClicked += lnkConfigureHSES_LinkClicked;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Cursor = Cursors.Help;
        label2.Location = new Point(139, 214);
        label2.Margin = new Padding(0);
        label2.Name = "label2";
        label2.Size = new Size(66, 15);
        label2.TabIndex = 26;
        label2.Text = "COM Port :";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cbComPorts
        // 
        cbComPorts.FormattingEnabled = true;
        cbComPorts.Location = new Point(208, 210);
        cbComPorts.Name = "cbComPorts";
        cbComPorts.Size = new Size(121, 23);
        cbComPorts.TabIndex = 27;
        cbComPorts.DropDown += cbComPorts_DropDown;
        // 
        // lnkConfigureHC
        // 
        lnkConfigureHC.Anchor = AnchorStyles.Left;
        lnkConfigureHC.AutoSize = true;
        lnkConfigureHC.Location = new Point(458, 162);
        lnkConfigureHC.Name = "lnkConfigureHC";
        lnkConfigureHC.Size = new Size(174, 15);
        lnkConfigureHC.TabIndex = 28;
        lnkConfigureHC.TabStop = true;
        lnkConfigureHC.Text = "See how to enable Host Control";
        lnkConfigureHC.LinkClicked += lnkConfigureHC_LinkClicked;
        // 
        // ConnectControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ConnectControl";
        Size = new Size(1091, 831);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblConnected;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox chkHSES;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.CheckBox chkHostControlEthernet;
    private System.Windows.Forms.Label label3;
    private Label lblLicense;
    private LinkLabel lnkConfigureHSES;
    private CheckBox chkHostControlSerial;
    private Label label2;
    private ComboBox cbComPorts;
    private LinkLabel lnkConfigureHC;
}
