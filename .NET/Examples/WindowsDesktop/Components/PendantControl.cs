using System.Windows.Forms;
using UnderAutomation.Yaskawa;

public partial class PendantControl : UserControl, IUserControl
{
    Yaskawa _robot;


    public PendantControl(Yaskawa Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.Connected;

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
        _robot.Display(txtMessage.Text);
    }

    private void btnLock_Click(object sender, System.EventArgs e)
    {
        _robot.ServoCommand(OnOffCommandType.HLock, true);
    }

    private void btnUnlock_Click(object sender, System.EventArgs e)
    {
        _robot.ServoCommand(OnOffCommandType.HLock, false);
    }
}
