using System;
using System.Drawing;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;

public partial class ConnectControl : UserControl, IUserControl
{
    Yaskawa _robot;

    public ConnectControl(Yaskawa Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        // Use stored information or set to default
        txtIP.Text = Config.Current.IP ?? "192.168.0.1";
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.Connected;

    public string Title => "Connection";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        var connected = FeatureEnabled;
        btnDisconnect.Enabled = connected;
        btnConnect.Text = connected ? "Reconnect" : "Connect";
        lblConnected.Text = connected ? "Connected" : "Disconnected";
        lblConnected.ForeColor = connected ? Color.Green : Color.Red;

    }
    #endregion

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;

        // Connect to the robot
        _robot.Connect(txtIP.Text);

        // Store information
        Config.Current.IP = txtIP.Text;
        Config.Save();
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _robot.Close();
    }
}
