//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple string variables (S variables) from the robot controller.
	/// S variables can be either 16-byte or 32-byte character strings depending on the command used.
	/// </summary>
	public class RobotStringVariableData : RobotData {

		/// <summary>
		/// Gets the array of string values read from the robot controller.
		/// Strings are null-terminated and trimmed of trailing null characters.
		/// </summary>
		public string[] Value { get; }
	}
}
