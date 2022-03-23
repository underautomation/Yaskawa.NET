using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class PositionControl : UserControl, IUserControl
{
    static PositionControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotPositionData<int>), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotPositionCartesianData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotPosture), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
    }

    YaskawaRobot _robot;


    public PositionControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Current position";

    public void OnClose()
    {
        worker.CancelAsync();
    }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        if (!worker.CancellationPending) worker.RunWorkerAsync();
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
                var error = _robot.HighSpeedEServer.GetPositionError();

                var cartesian = _robot.HighSpeedEServer.GetRobotCartesianPosition();

                var joints = _robot.HighSpeedEServer.GetRobotJointPosition();

                this.Invoke(new Action(() =>
                {
                    gridCartesian.SelectedObject = cartesian;
                    gridJoints.SelectedObject = joints;
                    gridError.SelectedObject = error;

                    gridCartesian.ExpandAllGridItems();
                    gridJoints.ExpandAllGridItems();
                    gridError.ExpandAllGridItems();
                }));

            }
            catch { }

            System.Threading.Thread.Sleep(100);
        }
    }
}
