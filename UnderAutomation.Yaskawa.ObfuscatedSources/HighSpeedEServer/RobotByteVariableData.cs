//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple byte variables (B variables) from the robot controller.
	/// B variables are 8-bit unsigned integer storage locations (0-255).
	/// </summary>
	public class RobotByteVariableData : RobotData {

		/// <summary>
		/// Gets the array of byte variable values read from the robot controller.
		/// </summary>
		public byte[] Value { get; }
	}
}
