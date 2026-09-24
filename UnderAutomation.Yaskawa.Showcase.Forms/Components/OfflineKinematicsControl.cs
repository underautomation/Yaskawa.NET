using System.ComponentModel;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.Kinematics;

public partial class OfflineKinematicsControl : UserControl, IUserControl
{
    YaskawaRobot _robot;
    public OfflineKinematicsControl(YaskawaRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(DhParameters), new TypeConverterAttribute(typeof(ObjectConverter)));

        _robot = robot;

        InitializeComponent();

        cbModele.Items.Clear();
        cbModele.Items.Add("");
        foreach (var model in Enum.GetNames<ArmKinematicModels>())
        {
            cbModele.Items.Add(model.ToString());
        }
        cbModele.SelectedIndex = 0;

        gridJointsFK.SelectedObject = new JointsAngles(10, 0, 0, 0, 0, 0);
        gridDH.SelectedObject = DhParameters.FromArmKinematicModel(ArmKinematicModels.GP7);
        gridCartesianIK.SelectedObject = new CartesianPosition(300, 0, 0, 0, 0, 0);

        lstIKResults.Items.Clear();
    }

    #region IUserControl
    public string Title => "Offline Kinematics";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate()
    {
        btnImportDH.Enabled = cbModele.SelectedIndex > 0;
        BtnCopyIKSelectedResult.Enabled = lstIKResults.SelectedItems.Count > 0;

        btnReadCurrentCartesianPosition.Enabled = _robot.HighSpeedEServer.Connected;
        btnReadCurrentJoints.Enabled = _robot.HighSpeedEServer.Connected;
        btnReadCurrentDh.Enabled = _robot.Ftp.Connected;

        btnCopyCurrentJoints.Enabled = gridCurrentJoints.SelectedObject is JointsAngles && gridCurrentDh.SelectedObject is DhParameters;
        btnCopyCurrentCartesian.Enabled = gridCurrentCartesian.SelectedObject is CartesianPosition && gridCurrentDh.SelectedObject is DhParameters;
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void btnCopyCurrentJoints_Click(object sender, EventArgs e)
    {
        var joints = gridCurrentJoints.SelectedObject as JointsAngles;
        var currentDh = gridCurrentDh.SelectedObject as DhParameters;
        if (joints is null || currentDh is null) return;

        gridJointsFK.SelectedObject = new JointsAngles(joints.Values);
        gridDH.SelectedObject = new DhParameters(currentDh);
        cbModele.SelectedIndex = 0;
    }

    private void btnCopyCurrentCartesian_Click(object sender, EventArgs e)
    {
        var CartesianPosition = gridCurrentCartesian.SelectedObject as CartesianPosition;
        var currentDh = gridCurrentDh.SelectedObject as DhParameters;
        if (CartesianPosition is null || currentDh is null) return;
        gridCartesianIK.SelectedObject = new CartesianPosition(CartesianPosition);
        gridDH.SelectedObject = new DhParameters(currentDh);
        cbModele.SelectedIndex = 0;
    }

    private void btnImportDH_Click(object sender, EventArgs e)
    {
        gridDH.SelectedObject = DhParameters.FromArmKinematicModel(Enum.Parse<ArmKinematicModels>(cbModele.SelectedItem.ToString()));
    }

    private void btnCopyFKResult_Click(object sender, EventArgs e)
    {
        var result = gridFKResult.SelectedObject as CartesianPosition;
        if (result is null) return;
        gridCartesianIK.SelectedObject = new CartesianPosition(result);
    }

    private void BtnCopyIKSelectedResult_Click(object sender, EventArgs e)
    {
        if (lstIKResults.SelectedItems.Count == 0) return;

        var joints = lstIKResults.SelectedItems[0].Tag as JointsAngles;

        if (joints is null) return;

        gridJointsFK.SelectedObject = new JointsAngles(joints.Values);
    }

    private void btnForwardKinematics_Click(object sender, EventArgs e)
    {
        var joints = gridJointsFK.SelectedObject as JointsAngles;
        var dh = gridDH.SelectedObject as DhParameters;

        if (joints is null || dh is null) return;

        gridFKResult.SelectedObject = KinematicsUtils.ForwardKinematics(joints, dh);
    }

    private void btnInvertKinematics_Click(object sender, EventArgs e)
    {
        var CartesianPosition = gridCartesianIK.SelectedObject as CartesianPosition;
        var dh = gridDH.SelectedObject as DhParameters;

        if (CartesianPosition is null || dh is null) return;

        var results = KinematicsUtils.InverseKinematics(CartesianPosition, dh);

        lstIKResults.Items.Clear();
        for (int i = 0; i < results.Length; i++)
        {
            var result = results[i];
            var item = new ListViewItem();
            item.Text = (i + 1).ToString();
            foreach (var value in result.Values) item.SubItems.Add(value.ToString("F4"));
            item.Tag = result;

            lstIKResults.Items.Add(item);
        }
    }

    private void btnReadCurrentJoints_Click(object sender, EventArgs e)
    {
        IJointPulses pos = null;
        if (_robot.HighSpeedEServer.Connected)
        {
            pos = _robot.HighSpeedEServer.GetRobotJointPosition();
        }

        gridCurrentJoints.SelectedObject = pos;
    }

    private void btnReadCurrentDh_Click(object sender, EventArgs e)
    {
        var file = _robot.HighSpeedEServer.GetFile("ALL.PRM");
        gridCurrentDh.SelectedObject = DhParameters.FromPrmContent(file.Content);
    }

    private void btnReadCurrentCartesianPosition_Click(object sender, EventArgs e)
    {
        ICartesianPosition pos = null;
        if (_robot.HighSpeedEServer.Connected)
        {
            pos = _robot.HighSpeedEServer.GetRobotCartesianPosition();
        }

        gridCurrentCartesian.SelectedObject = pos;
    }
}
