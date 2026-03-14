//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace HighSpeedEServer {
	/// <summary>
	/// Represents robot position data with 32-bit integer axis values.
	/// This is the primary type used for pulse-based position data from the High Speed Ethernet Server.
	/// Axis values are in pulse units (encoder counts) or scaled coordinate values.
	/// </summary>
	public class RobotPositionIntData : RobotPositionData<int> {

		/// <summary>
		/// Creates a blank instance of RobotPositionIntData
		/// </summary>
		public RobotPositionIntData() : base(default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new instance of RobotPositionIntData with the specified header information.
		/// </summary>
		/// <param name="header">Response header containing metadata about the communication.</param>
		public RobotPositionIntData(RobotDataHeader header) : base(default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
