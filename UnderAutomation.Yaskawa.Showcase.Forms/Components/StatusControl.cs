using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class StatusControl : UserControl, IUserControl
{
    static StatusControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotJobData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotSystemInformation), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotManagementTimeData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

    }


    YaskawaRobot _robot;


    public StatusControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Status";

    public void OnClose()
    {
        if (worker.IsBusy) worker.CancelAsync();
    }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        if (!worker.CancellationPending) worker.RunWorkerAsync();

        gridInfo.SelectedObject = _robot.HighSpeedEServer.GetSystemInformation();
    }

    public void PeriodicUpdate()
    {

    }
    #endregion

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
        while (!worker.CancellationPending)
        {
            try
            {
                var jobInformation = _robot.HighSpeedEServer.GetExecutingJobInformation();
                var status = _robot.HighSpeedEServer.GetStatusInformation();

                var time = new ManagementTime();

                time.ControlPowerOnTime = GetManagementTime(ManagementTimeType.ControlPowerOnTime);
                time.ServoPowerOnTimeTotal = GetManagementTime(ManagementTimeType.ServoPowerOnTimeTotal);
                time.ServoPowerOnTimR1ToR8 = GetManagementTime(ManagementTimeType.ServoPowerOnTimR1ToR8);
                time.ServoPowerOnTimeS1ToS24 = GetManagementTime(ManagementTimeType.ServoPowerOnTimeS1ToS24);
                time.PlayBackTimeTotal = GetManagementTime(ManagementTimeType.PlayBackTimeTotal);
                time.PlayBackTimeR1ToR8 = GetManagementTime(ManagementTimeType.PlayBackTimeR1ToR8);
                time.PlayBackTimeS1ToS24 = GetManagementTime(ManagementTimeType.PlayBackTimeS1ToS24);
                time.MotionTimeTotal = GetManagementTime(ManagementTimeType.MotionTimeTotal);
                time.MotionTimeR1ToR8 = GetManagementTime(ManagementTimeType.MotionTimeR1ToR8);
                time.MotionTimeS1ToS24 = GetManagementTime(ManagementTimeType.MotionTimeS1ToS24);
                time.OperationTimeApplication1To8 = GetManagementTime(ManagementTimeType.OperationTimeApplication1To8);

                this.Invoke(new Action(() =>
                {
                    gridExecuting.SelectedObject = jobInformation;
                    gridStatus.SelectedObject = status;
                    gridTime.SelectedObject = time;
                    gridTime.ExpandAllGridItems();
                }));

            }
            catch { }
            System.Threading.Thread.Sleep(100);
        }
    }

    private RobotManagementTimeData GetManagementTime(ManagementTimeType time)
    {
        try
        {
            return _robot.HighSpeedEServer.GetManagementTime(time);
        }
        catch
        {
            return null;
        }
    }

    [ReadOnly(true)]
    public class ManagementTime
    {
        public RobotManagementTimeData ControlPowerOnTime { get; set; }
        public RobotManagementTimeData ServoPowerOnTimeTotal { get; set; }
        public RobotManagementTimeData ServoPowerOnTimR1ToR8 { get; set; }
        public RobotManagementTimeData ServoPowerOnTimeS1ToS24 { get; set; }
        public RobotManagementTimeData PlayBackTimeTotal { get; set; }
        public RobotManagementTimeData PlayBackTimeR1ToR8 { get; set; }
        public RobotManagementTimeData PlayBackTimeS1ToS24 { get; set; }
        public RobotManagementTimeData MotionTimeTotal { get; set; }
        public RobotManagementTimeData MotionTimeR1ToR8 { get; set; }
        public RobotManagementTimeData MotionTimeS1ToS24 { get; set; }
        public RobotManagementTimeData OperationTimeApplication1To8 { get; set; }

    }
}
