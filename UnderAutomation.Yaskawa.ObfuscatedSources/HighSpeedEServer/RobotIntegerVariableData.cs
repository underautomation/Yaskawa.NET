//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple integer variables (I variables) from the robot controller.
	/// I variables are 16-bit signed integer storage locations.
	/// </summary>
	public class RobotIntegerVariableData : RobotData {

		/// <summary>
		/// Gets the array of integer variable values read from the robot controller.
		/// </summary>
		public short[] Value { get; }
	}
}
