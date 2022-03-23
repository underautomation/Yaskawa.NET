using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class AlarmControl : UserControl, IUserControl
{
    static AlarmControl()
    {
        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotSystemInformation), new ReadOnlyAttribute(true));
    }

    YaskawaRobot _robot;

    public AlarmControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Alarms and system info";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        // Get last 4 alarms
        var alarms = new List<RobotAlarmData>();
        for (var i = RobotRecentAlarm.Latest; i <= RobotRecentAlarm.FourthLatest; i++)
        {
            var alarm = _robot.HighSpeedEServer.GetAlarm(i);
            alarms.Add(alarm);
        }

        // Display alarms
        lstActiveAlarms.UpdateList(
            alarms,
            a => a.OccurringTime,
            a => a.Code,
            a => a.Data,
            a => a.Type,
            a => a.Text
        );
    }

    public void PeriodicUpdate()
    {

    }
    #endregion

    private void btnReset_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.AlarmReset(AlarmResetType.Reset);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        OnOpen();
    }

}
