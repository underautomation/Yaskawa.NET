//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple position variables (P variables) from the robot controller.
	/// P variables store complete robot position data including coordinates, posture, tool and user coordinate references.
	/// </summary>
	public class RobotPositionVariableData : RobotData {

		/// <summary>
		/// Gets the array of position variable data read from the robot controller.
		/// Each element contains full position information including axis values, posture, and coordinate references.
		/// </summary>
		public RobotPositionIntData[] Value { get; }
	}
}
