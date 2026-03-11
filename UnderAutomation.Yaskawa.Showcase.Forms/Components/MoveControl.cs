using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class MoveControl : UserControl, IUserControl
{
    YaskawaRobot _robot;

    private readonly int[] _joints = new int[8];

    public MoveControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var type in System.Enum.GetValues(typeof(PositionCommandType)))
        {
            cbCartesianCommandType.Items.Add(type);
        }
        cbCartesianCommandType.SelectedIndex = 0;

        foreach (var type in System.Enum.GetValues(typeof(PositionCommandOperationCoordinate)))
            cbFrame.Items.Add(type);
        cbFrame.SelectedIndex = 0;

        cbUnit.SelectedIndex = 0;

        gridJoints.SelectedObject = _joints;
        gridPosture.SelectedObject = new RobotPosture();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Move robot";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {

    }
    #endregion



    private void btnMoveJoints_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.MoveJoints(_joints, PositionCommandClassification.LinkPercent, (double)nudSpeedJoint.Value, PositionCommandType.LinkAbsolute, RobotControlGroup: 1, StationControlGroup: 0);
    }

    private void btnMoveCartesian_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.MoveCartesian((double)nudX.Value, (double)nudY.Value, (double)nudZ.Value, (double)nudRx.Value, (double)nudRy.Value, (double)nudRz.Value,
            (PositionCommandClassification)cbUnit.SelectedIndex, (double)nudSpeedCartesian.Value, (PositionCommandOperationCoordinate)cbFrame.SelectedItem, (RobotPosture)gridPosture.SelectedObject, (PositionCommandType)cbCartesianCommandType.SelectedItem,
            tool: (int)nudTool.Value, userCoordinate: (int)nudUserCoordinate.Value);
    }

    private void cbFrame_SelectedIndexChanged(object sender, EventArgs e)
    {
        nudUserCoordinate.Enabled = (PositionCommandOperationCoordinate)cbFrame.SelectedItem == PositionCommandOperationCoordinate.User;
    }

    private void btnServoOn_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Servo, true);
    }

    private void btnServoOff_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Servo, false);
    }

    private void btnCopyJoint_Click(object sender, EventArgs e)
    {
        int[] axes = _robot.HighSpeedEServer.GetRobotJointPosition().Axes;

        for (int i = 0; i < axes.Length; i++)
            _joints[i] = axes[i];

        gridJoints.SelectedObject = _joints;
    }

    private void btnCopyCartesian_Click(object sender, EventArgs e)
    {
        RobotPositionCartesianData position = _robot.HighSpeedEServer.GetRobotCartesianPosition();

        nudX.Value = (decimal)position.X;
        nudY.Value = (decimal)position.Y;
        nudZ.Value = (decimal)position.Z;
        nudRx.Value = (decimal)position.Rx;
        nudRy.Value = (decimal)position.Ry;
        nudRz.Value = (decimal)position.Rz;

        gridPosture.SelectedObject = position.Form;

        nudTool.Value = position.ToolNumber;
        nudUserCoordinate.Value = position.UserCoordinateNumber;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Hold, true);
        _robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Hold, false);
    }
}
