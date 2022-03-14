using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;

public partial class JobControl : UserControl, IUserControl
{
    static JobControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotJobData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
    }

    Yaskawa _robot;

    public JobControl(Yaskawa Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.Connected;

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
        gridExecuting.SelectedObject = _robot.GetExecutingJobInformation();
        gridStatus.SelectedObject = _robot.GetStatusInformation();
    }

    #endregion

    private void btnSelect_Click(object sender, EventArgs e)
    {
        _robot.SelectJob(cbJobs.Text, (int)udJobLine.Value);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshList();
    }

    private void RefreshList()
    {
        if (!FeatureEnabled) return;

        var files = _robot.GetFileList("*.JBI")?.Files;

        if (files is null) return;

        cbJobs.Items.Clear();

        foreach(var file in files)
        {
            cbJobs.Items.Add(Path.GetFileNameWithoutExtension(file));
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _robot.StartJob();
    }

    private void btnServoOff_Click(object sender, EventArgs e)
    {
        _robot.ServoCommand(OnOffCommandType.Servo, false);
    }

    private void btnServoOn_Click(object sender, EventArgs e)
    {
        _robot.ServoCommand(OnOffCommandType.Servo, true);
    }

}
