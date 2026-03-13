//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Joint-space position result from a kinematics conversion.
	/// Provides the 8 joint axis values in both raw 0.0001° units and as a ready-to-use degrees array.
	/// </summary>
	public class RobotKinematicsJointData : RobotKinematicsPositionData {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the 8 joint axis values converted to degrees.
		/// Each element equals the corresponding <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.RobotKinematicsPositionData.Axes" data-throw-if-not-resolved="false"></xref> value divided by 10 000.
		/// </summary>
		public double[] AxisDegrees { get; }
	}
}
