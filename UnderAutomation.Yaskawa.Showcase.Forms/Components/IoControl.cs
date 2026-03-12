using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class IoControl : UserControl, IUserControl
{
    YaskawaRobot _robot;


    public IoControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var item in Enum.GetValues(typeof(IOType)))
        {
            cbType.Items.Add(item);
        }
        cbType.SelectedIndex = 0;

        grid.SelectedObject = new byte[2];

    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Inputs / Outputs";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {

    }
    #endregion

    private void btnRead_Click(object sender, EventArgs e)
    {
        IOType type = (IOType)cbType.SelectedItem;
        RobotIOData data = _robot.HighSpeedEServer.ReadIO(type, (ushort)nudGroup.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;

        var strValue = new string[data.Value.Length];

        for (int i = 0; i < strValue.Length; i++)
        {
            strValue[i] = $"#{(IoHelpers.ConvertIOGroupToBitAddress(type, (ushort)(nudGroup.Value + i), 0) / 10).ToString("0000")} : {data.Value[i]}";
        }

        gridName.SelectedObject = strValue;

    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.WriteIoNetworkInput((ushort)nudGroup.Value, (byte[])grid.SelectedObject);
    }

    private void cbType_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnWrite.Enabled = IOType.NetworkInput.Equals(cbType.SelectedItem);
    }
}
