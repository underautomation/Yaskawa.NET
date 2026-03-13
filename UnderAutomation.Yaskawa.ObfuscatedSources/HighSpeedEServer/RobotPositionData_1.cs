//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents generic robot position data with axis values of the specified type.
	/// This class provides a flexible structure for storing position information that can be
	/// represented in different data formats (pulse values, Cartesian coordinates, etc.).
	/// </summary>
	public class RobotPositionData<T> : RobotAxisRawData<T> {

		/// <summary>
		/// Creates a new instance of RobotPositionData with the specified header information.
		/// </summary>
		/// <param name="header">Response header containing metadata about the communication.</param>
		public RobotPositionData(RobotDataHeader header)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the robot posture (form) data defining the robot's kinematic configuration.
		/// This includes flip/no-flip state, arm configuration (upper/lower), and axis angle ranges.
		/// </summary>
		public RobotPosture Form { get; set; }

		/// <summary>
		/// Gets or sets the position data type indicating the coordinate system used.
		/// Determines how axis values should be interpreted (pulse, base, robot, user, or tool coordinates).
		/// </summary>
		public RobotPositionDataType DataType { get; set; }

		/// <summary>
		/// Gets or sets the tool number (TCP - Tool Center Point) used for this position.
		/// Tool numbers typically range from 0-63, where 0 is often the robot flange center.
		/// </summary>
		public int ToolNumber { get; set; }

		/// <summary>
		/// Gets or sets the user coordinate system number used for this position.
		/// User coordinates define custom reference frames for specific workpiece locations.
		/// </summary>
		public int UserCoordinateNumber { get; set; }
	}
}
