using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class PendantControl : UserControl, IUserControl
{
    YaskawaRobot _robot;


    public PendantControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Teach Pendant";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {

    }
    #endregion

    private void btnPopup_Click(object sender, System.EventArgs e)
    {
        _robot.HighSpeedEServer.Display(txtMessage.Text);
    }

    private void btnLock_Click(object sender, System.EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.HLock, true);
    }

    private void btnUnlock_Click(object sender, System.EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.HLock, false);
    }
}
