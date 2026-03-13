//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace HighSpeedEServer {
	/// <summary>
	/// Represents external axis position data for positioners, travel units, or additional servo axes.
	/// External axes are coordinated with the robot motion for applications like welding positioners.
	/// </summary>
	public class RobotExternalAxisData : RobotAxisRawData<int> {

		/// <summary>
		/// Creates a new instance of RobotExternalAxisData with the specified header information.
		/// </summary>
		/// <param name="header">Response header containing metadata about the communication.</param>
		public RobotExternalAxisData(RobotDataHeader header)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new instance of RobotExternalAxisData from a generic RobotAxisRawData.
		/// Used for conversion from generic types to specific types.
		/// </summary>
		/// <param name="source">Source axis data to copy from.</param>
		public RobotExternalAxisData(RobotAxisRawData<int> source)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
