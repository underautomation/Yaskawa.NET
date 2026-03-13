//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents data returned from reading multiple I/O (Input/Output) points from the robot controller.
	/// I/O addresses are organized in groups based on their function and accessibility.
	/// </summary>
	public class RobotIOData : RobotData {

		/// <summary>
		/// Gets the array of I/O byte values read from the robot controller.
		/// Each byte represents 8 consecutive I/O points where each bit corresponds to one I/O state.
		/// </summary>
		public byte[] Value { get; }
	}
}
