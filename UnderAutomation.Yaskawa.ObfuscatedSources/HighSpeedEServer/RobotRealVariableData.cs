//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple real variables (R variables) from the robot controller.
	/// R variables are 32-bit single-precision floating point storage locations.
	/// </summary>
	public class RobotRealVariableData : RobotData {

		/// <summary>
		/// Gets the array of single-precision floating point values read from the robot controller.
		/// </summary>
		public float[] Value { get; }
	}
}
