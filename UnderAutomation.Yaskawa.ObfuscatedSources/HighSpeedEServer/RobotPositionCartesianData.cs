//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents Cartesian position data with coordinates in millimeters and degrees.
	/// This class provides human-readable position data converted from the raw protocol values.
	/// </summary>
	public class RobotPositionCartesianData : RobotData {

		/// <summary>
		/// Gets the robot posture (form) data defining the kinematic configuration.
		/// </summary>
		public RobotPosture Form { get; }

		/// <summary>
		/// Gets the position data type indicating the coordinate system used.
		/// </summary>
		public RobotPositionDataType DataType { get; }

		/// <summary>
		/// Gets the tool number (TCP) used for this position.
		/// </summary>
		public int ToolNumber { get; }

		/// <summary>
		/// Gets the user coordinate system number used for this position.
		/// </summary>
		public int UserCoordinateNumber { get; }

		/// <summary>
		/// Gets the X coordinate in millimeters.
		/// </summary>
		public double X { get; }

		/// <summary>
		/// Gets the Y coordinate in millimeters.
		/// </summary>
		public double Y { get; }

		/// <summary>
		/// Gets the Z coordinate in millimeters.
		/// </summary>
		public double Z { get; }

		/// <summary>
		/// Gets the rotation around X axis (Rx) in degrees.
		/// </summary>
		public double Rx { get; }

		/// <summary>
		/// Gets the rotation around Y axis (Ry) in degrees.
		/// </summary>
		public double Ry { get; }

		/// <summary>
		/// Gets the rotation around Z axis (Rz) in degrees.
		/// </summary>
		public double Rz { get; }
	}
}
