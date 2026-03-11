using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class ParametersControl : UserControl, IUserControl
{
    YaskawaRobot _robot;


    public ParametersControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var type in System.Enum.GetValues(typeof(SystemParameterTypes)))
            cbType.Items.Add(type);

        cbType.SelectedIndex = 0;
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "System Parameters";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {

    }
    #endregion


    private void btnReadParameter_Click(object sender, EventArgs e)
    {
        RobotSystemParamData data = _robot.HighSpeedEServer.GetSystemParameter((SystemParameterTypes)cbType.SelectedItem, (int)nudIndex.Value, (int)nudGroup.Value);

        txtValue.Text = data.Value.ToString();
    }

    private void cbType_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}
