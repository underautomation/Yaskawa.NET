//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple double-precision integer variables (D variables) from the robot controller.
	/// </summary>
	public class RobotDoubleIntegerVariableData : RobotData {

		/// <summary>
		/// Gets the array of double integer values read from the robot controller.
		/// </summary>
		public int[] Value { get; }
	}
}
