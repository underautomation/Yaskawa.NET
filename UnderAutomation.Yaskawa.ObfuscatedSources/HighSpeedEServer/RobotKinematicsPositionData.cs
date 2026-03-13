//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Base class for kinematic position data exchanged with the robot controller.
	/// Contains coordinate type, posture flags, tool/user numbers, and the 8 raw axis values.
	/// </summary>
	public class RobotKinematicsPositionData : RobotData {

		/// <summary>
		/// Creates a blank instance for use as input to kinematics conversion methods.
		/// </summary>
		public RobotKinematicsPositionData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets or sets the coordinate type of this position.
		/// </summary>
		public RobotPositionDataType DataType { get; set; }

		/// <summary>
		/// Gets or sets the posture/form flags for this position.
		/// </summary>
		public RobotPosture Form { get; set; }

		/// <summary>
		/// Gets or sets the tool number used for this position.
		/// </summary>
		public int ToolNumber { get; set; }

		/// <summary>
		/// Gets or sets the user coordinate number used for this position.
		/// </summary>
		public int UserCoordinateNumber { get; set; }

		/// <summary>
		/// Gets or sets the 8 raw axis values.
		/// For joint positions: values in 0.0001° units (divide by 10 000 for degrees).
		/// For Cartesian positions: XYZ axes (0–2) in µm; orientation axes (3–5) in 0.0001°.
		/// </summary>
		public int[] Axes { get; set; }
	}
}
