using System.ComponentModel;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class VariableControl : UserControl, IUserControl
{
    YaskawaRobot _robot;


    public VariableControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;

        TypeDescriptor.AddAttributes(typeof(RobotPositionIntData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Variables";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {
        btnWriteByte.Enabled = grid.SelectedObject is byte[];
        btnWriteRegister.Enabled = grid.SelectedObject is short[];
        btnWriteInteger.Enabled = grid.SelectedObject is short[];
        btnWriteDouble.Enabled = grid.SelectedObject is Int32[];
        btnWriteReal.Enabled = grid.SelectedObject is float[];
        btnWrite32Char.Enabled = grid.SelectedObject is string[];
        btnWritePositionVariable.Enabled = grid.SelectedObject is RobotPositionIntData[];
    }
    #endregion



    private void btnReadByte_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.ReadByte((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWriteByte_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WriteByte((int)nudIndex.Value, (byte[])grid.SelectedObject);
    }

    private void btnReadRegister_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.ReadRegister((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWriteRegister_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WriteRegister((int)nudIndex.Value, (short[])grid.SelectedObject);
    }

    private void btnReadInteger_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.ReadInteger((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWriteInteger_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WriteInteger((int)nudIndex.Value, (short[])grid.SelectedObject);
    }

    private void btnReadDouble_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.ReadDoubleInteger((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWriteDouble_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WriteDoubleInteger((int)nudIndex.Value, (Int32[])grid.SelectedObject);
    }

    private void btnReadReal_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.ReadReal((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWriteReal_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WriteReal((int)nudIndex.Value, (float[])grid.SelectedObject);
    }

    private void btnRead32Char_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.Read32BytesChar((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWrite32Char_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.Write32BytesChar((int)nudIndex.Value, (string[])grid.SelectedObject);
    }

    private void btnReadPositionVariable_Click(object sender, EventArgs e)
    {
        var data = _robot.HighSpeedEServer.ReadPositionVariable((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
        grid.ExpandAllGridItems();
    }

    private void btnWritePositionVariable_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WritePositionVariable((int)nudIndex.Value, (RobotPositionIntData[])grid.SelectedObject);
    }

}
