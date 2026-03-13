//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace HighSpeedEServer {
	/// <summary>
	/// Represents base position data for coordinated motion with travel units or external bases.
	/// Base positions define the location of the robot's base in world coordinates or pulse values.
	/// </summary>
	public class RobotBasePositionData : RobotAxisRawData<int> {

		/// <summary>
		/// Creates a new instance of RobotBasePositionData with the specified header information.
		/// </summary>
		/// <param name="header">Response header containing metadata about the communication.</param>
		public RobotBasePositionData(RobotDataHeader header)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the data type indicating whether values are pulse or coordinate values.
		/// </summary>
		public RobotBasePositionType DataType { get; }
	}
}
