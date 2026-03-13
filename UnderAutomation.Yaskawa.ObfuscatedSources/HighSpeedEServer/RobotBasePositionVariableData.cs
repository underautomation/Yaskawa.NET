//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple base position variables (BP variables) from the robot controller.
	/// BP variables store base position information used for coordinated motion with external axes or travel units.
	/// </summary>
	public class RobotBasePositionVariableData : RobotData {

		/// <summary>
		/// Gets the array of base position data read from the robot controller.
		/// </summary>
		public RobotBasePositionData[] Value { get; }
	}
}
