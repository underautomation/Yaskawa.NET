using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.License;

public partial class ConnectControl : UserControl, IUserControl
{
    YaskawaRobot _robot;

    public ConnectControl(YaskawaRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        var parameters = Config.Current.ConnectParameters ?? new ConnectParameters();

        // Use stored information or set to default
        txtIP.Text = parameters.IP ?? "192.168.0.1";

        chkHSES.Checked = parameters.HighSpeedEServer.Enable;

    }


    #region IUserControl
    public bool FeatureEnabled => _robot.Connected;

    public string Title => "Connection";

    public void OnClose() { }

    public void OnOpen() { ValidateLicense(); }

    public void PeriodicUpdate()
    {
        var connected = FeatureEnabled;
        btnDisconnect.Enabled = connected;
        btnConnect.Text = connected ? "Reconnect" : "Connect";
        lblConnected.Text = connected ? "Connected" : "Disconnected";
        lblConnected.ForeColor = connected ? Color.Green : Color.Red;

    }
    #endregion

    public void ValidateLicense()
    {
        var licenseInfo = YaskawaRobot.LicenseInfo;
        var isActiveLicense = licenseInfo.State == LicenseState.Licensed || licenseInfo.State == LicenseState.Trial || licenseInfo.State == LicenseState.ExtraTrial;

        lblLicense.Text = "License state : " + YaskawaRobot.LicenseInfo.State;
        lblLicense.ForeColor = isActiveLicense ? Color.Green : Color.Black;
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        var parameters = new ConnectParameters();
        
        parameters.IP = txtIP.Text;
        parameters.HighSpeedEServer.Enable = chkHSES.Checked;

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();

        try
        {
            // Connect to the robot
            _robot.Connect(parameters);
        }
        catch (InvalidLicenseException)
        {
            MessageBox.Show("Your licence is invalid. Please obtain a Trial Licence or enter the licence key you receive after purchasing the SDK", "License error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MainForm.Instance.SelectNode<LicenseControl>();
        }
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _robot.Disconnect();
    }

    private void lnkConfigureHSES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MainForm.Instance.OpenUrl("https://underautomation.com/yaskawa/documentation/");
    }

}
