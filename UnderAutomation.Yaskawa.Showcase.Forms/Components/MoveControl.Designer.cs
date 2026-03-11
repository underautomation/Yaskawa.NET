
partial class MoveControl
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
        gridJoints = new PropertyGrid();
        btnMoveJoints = new Button();
        nudSpeedJoint = new NumericUpDown();
        label1 = new Label();
        label2 = new Label();
        btnMoveCartesian = new Button();
        label4 = new Label();
        nudX = new NumericUpDown();
        nudY = new NumericUpDown();
        label5 = new Label();
        nudZ = new NumericUpDown();
        label6 = new Label();
        nudRx = new NumericUpDown();
        label7 = new Label();
        nudRy = new NumericUpDown();
        label8 = new Label();
        nudRz = new NumericUpDown();
        label9 = new Label();
        label10 = new Label();
        nudSpeedCartesian = new NumericUpDown();
        cbUnit = new ComboBox();
        label11 = new Label();
        cbCartesianCommandType = new ComboBox();
        label12 = new Label();
        label13 = new Label();
        cbFrame = new ComboBox();
        gridPosture = new PropertyGrid();
        label14 = new Label();
        nudTool = new NumericUpDown();
        label15 = new Label();
        nudUserCoordinate = new NumericUpDown();
        btnServoOn = new Button();
        btnServoOff = new Button();
        btnCopyJoint = new Button();
        btnCopyCartesian = new Button();
        btnStop = new Button();
        ((System.ComponentModel.ISupportInitialize)nudSpeedJoint).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudZ).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRx).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRy).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRz).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSpeedCartesian).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTool).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudUserCoordinate).BeginInit();
        SuspendLayout();
        // 
        // gridJoints
        // 
        gridJoints.HelpVisible = false;
        gridJoints.Location = new Point(101, 131);
        gridJoints.Name = "gridJoints";
        gridJoints.PropertySort = PropertySort.Alphabetical;
        gridJoints.Size = new Size(160, 194);
        gridJoints.TabIndex = 26;
        gridJoints.ToolbarVisible = false;
        // 
        // btnMoveJoints
        // 
        btnMoveJoints.Location = new Point(101, 413);
        btnMoveJoints.Name = "btnMoveJoints";
        btnMoveJoints.Size = new Size(160, 23);
        btnMoveJoints.TabIndex = 27;
        btnMoveJoints.Text = "Move joints";
        btnMoveJoints.UseVisualStyleBackColor = true;
        btnMoveJoints.Click += btnMoveJoints_Click;
        // 
        // nudSpeedJoint
        // 
        nudSpeedJoint.DecimalPlaces = 2;
        nudSpeedJoint.Location = new Point(101, 372);
        nudSpeedJoint.Name = "nudSpeedJoint";
        nudSpeedJoint.Size = new Size(160, 23);
        nudSpeedJoint.TabIndex = 28;
        nudSpeedJoint.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // label1
        // 
        label1.Location = new Point(86, 349);
        label1.Name = "label1";
        label1.Size = new Size(175, 23);
        label1.TabIndex = 29;
        label1.Text = "Speed (%):";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new Point(77, 105);
        label2.Name = "label2";
        label2.Size = new Size(184, 23);
        label2.TabIndex = 29;
        label2.Text = "Joints position (pulses):";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnMoveCartesian
        // 
        btnMoveCartesian.Location = new Point(385, 468);
        btnMoveCartesian.Name = "btnMoveCartesian";
        btnMoveCartesian.Size = new Size(335, 23);
        btnMoveCartesian.TabIndex = 27;
        btnMoveCartesian.Text = "Move Cartesian";
        btnMoveCartesian.UseVisualStyleBackColor = true;
        btnMoveCartesian.Click += btnMoveCartesian_Click;
        // 
        // label4
        // 
        label4.Location = new Point(370, 131);
        label4.Name = "label4";
        label4.Size = new Size(75, 23);
        label4.TabIndex = 29;
        label4.Text = "X (mm):";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudX
        // 
        nudX.DecimalPlaces = 2;
        nudX.Location = new Point(451, 131);
        nudX.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudX.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudX.Name = "nudX";
        nudX.Size = new Size(94, 23);
        nudX.TabIndex = 28;
        // 
        // nudY
        // 
        nudY.DecimalPlaces = 2;
        nudY.Location = new Point(451, 160);
        nudY.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudY.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudY.Name = "nudY";
        nudY.Size = new Size(94, 23);
        nudY.TabIndex = 28;
        // 
        // label5
        // 
        label5.Location = new Point(370, 160);
        label5.Name = "label5";
        label5.Size = new Size(75, 23);
        label5.TabIndex = 29;
        label5.Text = "Y (mm):";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudZ
        // 
        nudZ.DecimalPlaces = 2;
        nudZ.Location = new Point(451, 189);
        nudZ.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudZ.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudZ.Name = "nudZ";
        nudZ.Size = new Size(94, 23);
        nudZ.TabIndex = 28;
        // 
        // label6
        // 
        label6.Location = new Point(370, 189);
        label6.Name = "label6";
        label6.Size = new Size(75, 23);
        label6.TabIndex = 29;
        label6.Text = "Z (mm):";
        label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRx
        // 
        nudRx.DecimalPlaces = 2;
        nudRx.Location = new Point(451, 218);
        nudRx.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudRx.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudRx.Name = "nudRx";
        nudRx.Size = new Size(94, 23);
        nudRx.TabIndex = 28;
        // 
        // label7
        // 
        label7.Location = new Point(370, 218);
        label7.Name = "label7";
        label7.Size = new Size(75, 23);
        label7.TabIndex = 29;
        label7.Text = "Rx (°):";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRy
        // 
        nudRy.DecimalPlaces = 2;
        nudRy.Location = new Point(451, 247);
        nudRy.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudRy.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudRy.Name = "nudRy";
        nudRy.Size = new Size(94, 23);
        nudRy.TabIndex = 28;
        // 
        // label8
        // 
        label8.Location = new Point(370, 247);
        label8.Name = "label8";
        label8.Size = new Size(75, 23);
        label8.TabIndex = 29;
        label8.Text = "Ry (°):";
        label8.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRz
        // 
        nudRz.DecimalPlaces = 2;
        nudRz.Location = new Point(451, 276);
        nudRz.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudRz.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudRz.Name = "nudRz";
        nudRz.Size = new Size(94, 23);
        nudRz.TabIndex = 28;
        // 
        // label9
        // 
        label9.Location = new Point(370, 276);
        label9.Name = "label9";
        label9.Size = new Size(75, 23);
        label9.TabIndex = 29;
        label9.Text = "Rz (°):";
        label9.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label10
        // 
        label10.Location = new Point(370, 302);
        label10.Name = "label10";
        label10.Size = new Size(75, 23);
        label10.TabIndex = 29;
        label10.Text = "Speed:";
        label10.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // nudSpeedCartesian
        // 
        nudSpeedCartesian.DecimalPlaces = 2;
        nudSpeedCartesian.Location = new Point(385, 323);
        nudSpeedCartesian.Name = "nudSpeedCartesian";
        nudSpeedCartesian.Size = new Size(160, 23);
        nudSpeedCartesian.TabIndex = 28;
        nudSpeedCartesian.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // cbUnit
        // 
        cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        cbUnit.FormattingEnabled = true;
        cbUnit.Items.AddRange(new object[] { "%", "mm/s", "°/s" });
        cbUnit.Location = new Point(548, 323);
        cbUnit.Name = "cbUnit";
        cbUnit.Size = new Size(63, 23);
        cbUnit.TabIndex = 30;
        // 
        // label11
        // 
        label11.Location = new Point(370, 349);
        label11.Name = "label11";
        label11.Size = new Size(175, 23);
        label11.TabIndex = 29;
        label11.Text = "Command type:";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cbCartesianCommandType
        // 
        cbCartesianCommandType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCartesianCommandType.FormattingEnabled = true;
        cbCartesianCommandType.Location = new Point(385, 375);
        cbCartesianCommandType.Name = "cbCartesianCommandType";
        cbCartesianCommandType.Size = new Size(160, 23);
        cbCartesianCommandType.TabIndex = 30;
        // 
        // label12
        // 
        label12.Location = new Point(370, 105);
        label12.Name = "label12";
        label12.Size = new Size(184, 23);
        label12.TabIndex = 29;
        label12.Text = "Cartesian position:";
        label12.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label13
        // 
        label13.Location = new Point(370, 401);
        label13.Name = "label13";
        label13.Size = new Size(175, 23);
        label13.TabIndex = 29;
        label13.Text = "Frame:";
        label13.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cbFrame
        // 
        cbFrame.DropDownStyle = ComboBoxStyle.DropDownList;
        cbFrame.FormattingEnabled = true;
        cbFrame.Location = new Point(385, 427);
        cbFrame.Name = "cbFrame";
        cbFrame.Size = new Size(160, 23);
        cbFrame.TabIndex = 30;
        cbFrame.SelectedIndexChanged += cbFrame_SelectedIndexChanged;
        // 
        // gridPosture
        // 
        gridPosture.HelpVisible = false;
        gridPosture.Location = new Point(560, 131);
        gridPosture.Name = "gridPosture";
        gridPosture.PropertySort = PropertySort.Alphabetical;
        gridPosture.Size = new Size(160, 168);
        gridPosture.TabIndex = 26;
        gridPosture.ToolbarVisible = false;
        // 
        // label14
        // 
        label14.Location = new Point(608, 375);
        label14.Name = "label14";
        label14.Size = new Size(51, 23);
        label14.TabIndex = 29;
        label14.Text = "Tool:";
        label14.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudTool
        // 
        nudTool.Location = new Point(665, 375);
        nudTool.Name = "nudTool";
        nudTool.Size = new Size(55, 23);
        nudTool.TabIndex = 28;
        // 
        // label15
        // 
        label15.Location = new Point(561, 426);
        label15.Name = "label15";
        label15.Size = new Size(98, 23);
        label15.TabIndex = 29;
        label15.Text = "User coordinate:";
        label15.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudUserCoordinate
        // 
        nudUserCoordinate.Location = new Point(665, 426);
        nudUserCoordinate.Name = "nudUserCoordinate";
        nudUserCoordinate.Size = new Size(55, 23);
        nudUserCoordinate.TabIndex = 28;
        nudUserCoordinate.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnServoOn
        // 
        btnServoOn.Location = new Point(197, 23);
        btnServoOn.Margin = new Padding(4, 3, 4, 3);
        btnServoOn.Name = "btnServoOn";
        btnServoOn.Size = new Size(152, 40);
        btnServoOn.TabIndex = 31;
        btnServoOn.Text = "Servo ON";
        btnServoOn.UseVisualStyleBackColor = true;
        btnServoOn.Click += btnServoOn_Click;
        // 
        // btnServoOff
        // 
        btnServoOff.Location = new Point(356, 23);
        btnServoOff.Margin = new Padding(4, 3, 4, 3);
        btnServoOff.Name = "btnServoOff";
        btnServoOff.Size = new Size(152, 40);
        btnServoOff.TabIndex = 32;
        btnServoOff.Text = "Servo OFF";
        btnServoOff.UseVisualStyleBackColor = true;
        btnServoOff.Click += btnServoOff_Click;
        // 
        // btnCopyJoint
        // 
        btnCopyJoint.Location = new Point(14, 205);
        btnCopyJoint.Name = "btnCopyJoint";
        btnCopyJoint.Size = new Size(81, 65);
        btnCopyJoint.TabIndex = 33;
        btnCopyJoint.Text = "Copy current position >>";
        btnCopyJoint.UseVisualStyleBackColor = true;
        btnCopyJoint.Click += btnCopyJoint_Click;
        // 
        // btnCopyCartesian
        // 
        btnCopyCartesian.Location = new Point(310, 179);
        btnCopyCartesian.Name = "btnCopyCartesian";
        btnCopyCartesian.Size = new Size(81, 65);
        btnCopyCartesian.TabIndex = 33;
        btnCopyCartesian.Text = "Copy current position >>";
        btnCopyCartesian.UseVisualStyleBackColor = true;
        btnCopyCartesian.Click += btnCopyCartesian_Click;
        // 
        // btnStop
        // 
        btnStop.Location = new Point(230, 523);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(171, 23);
        btnStop.TabIndex = 34;
        btnStop.Text = "Stop motion";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // MoveControl
        // 
        Controls.Add(btnStop);
        Controls.Add(btnCopyCartesian);
        Controls.Add(btnCopyJoint);
        Controls.Add(btnServoOn);
        Controls.Add(btnServoOff);
        Controls.Add(nudUserCoordinate);
        Controls.Add(nudTool);
        Controls.Add(nudSpeedCartesian);
        Controls.Add(cbUnit);
        Controls.Add(cbFrame);
        Controls.Add(cbCartesianCommandType);
        Controls.Add(label12);
        Controls.Add(label13);
        Controls.Add(label2);
        Controls.Add(label15);
        Controls.Add(label11);
        Controls.Add(label14);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label1);
        Controls.Add(nudRz);
        Controls.Add(nudRy);
        Controls.Add(nudRx);
        Controls.Add(nudZ);
        Controls.Add(nudY);
        Controls.Add(nudX);
        Controls.Add(nudSpeedJoint);
        Controls.Add(btnMoveCartesian);
        Controls.Add(btnMoveJoints);
        Controls.Add(gridPosture);
        Controls.Add(gridJoints);
        Name = "MoveControl";
        Size = new Size(823, 575);
        ((System.ComponentModel.ISupportInitialize)nudSpeedJoint).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudZ).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRx).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRy).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRz).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSpeedCartesian).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTool).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudUserCoordinate).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid gridJoints;
    private Button btnMoveJoints;
    private NumericUpDown nudSpeedJoint;
    private Label label1;
    private Label label2;
    private Button btnMoveCartesian;
    private Label label4;
    private NumericUpDown nudX;
    private NumericUpDown nudY;
    private Label label5;
    private NumericUpDown nudZ;
    private Label label6;
    private NumericUpDown nudRx;
    private Label label7;
    private NumericUpDown nudRy;
    private Label label8;
    private NumericUpDown nudRz;
    private Label label9;
    private Label label10;
    private NumericUpDown nudSpeedCartesian;
    private ComboBox cbUnit;
    private Label label11;
    private ComboBox cbCartesianCommandType;
    private Label label12;
    private Label label13;
    private ComboBox cbFrame;
    private PropertyGrid gridPosture;
    private Label label14;
    private NumericUpDown nudTool;
    private Label label15;
    private NumericUpDown nudUserCoordinate;
    private Button btnServoOn;
    private Button btnServoOff;
    private Button btnCopyJoint;
    private Button btnCopyCartesian;
    private Button btnStop;
}
