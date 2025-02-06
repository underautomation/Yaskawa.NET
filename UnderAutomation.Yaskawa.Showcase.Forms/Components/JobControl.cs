using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class JobControl : UserControl, IUserControl
{
    static JobControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotJobData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
    }

    YaskawaRobot _robot;

    public JobControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Job";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        RefreshList();

    }

    public void PeriodicUpdate()
    {
        if (!FeatureEnabled) return;
        gridExecuting.SelectedObject = _robot.HighSpeedEServer.GetExecutingJobInformation();
        gridStatus.SelectedObject = _robot.HighSpeedEServer.GetStatusInformation();
    }

    #endregion

    private void btnSelect_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.SelectJob(cbJobs.Text, (int)udJobLine.Value);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshList();
    }

    private void RefreshList()
    {
        if (!FeatureEnabled) return;

        var files = _robot.HighSpeedEServer.GetFileList("*.JBI")?.Files;

        if (files is null) return;

        cbJobs.Items.Clear();

        foreach (var file in files)
        {
            cbJobs.Items.Add(Path.GetFileNameWithoutExtension(file));
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.StartJob();
    }

    private void btnServoOff_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Servo, false);
    }

    private void btnServoOn_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Servo, true);
    }

}
