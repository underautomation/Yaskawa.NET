//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple register values from the robot controller.
	/// Registers are 16-bit signed integer storage locations used for general-purpose data.
	/// </summary>
	public class RobotRegisterData : RobotData {

		/// <summary>
		/// Gets the array of register values read from the robot controller.
		/// Each value is a 16-bit signed integer (-32768 to 32767).
		/// </summary>
		public short[] Value { get; }
	}
}
