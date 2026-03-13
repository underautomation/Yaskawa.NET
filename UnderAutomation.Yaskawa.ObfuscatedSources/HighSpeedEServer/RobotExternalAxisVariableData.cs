//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple external axis variables (EX variables) from the robot controller.
	/// EX variables store position data for external axes such as positioners, travel units, or additional servo axes.
	/// </summary>
	public class RobotExternalAxisVariableData : RobotData {

		/// <summary>
		/// Gets the array of external axis data read from the robot controller.
		/// </summary>
		public RobotExternalAxisData[] Value { get; }
	}
}
