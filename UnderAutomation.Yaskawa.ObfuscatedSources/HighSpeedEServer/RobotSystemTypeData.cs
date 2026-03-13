//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents a system type and index combination for querying specific robot system components.
	/// Used to specify which robot, station, or application to query in multi-robot configurations.
	/// </summary>
	public class RobotSystemTypeData {

		/// <summary>
		/// Default system type data for querying the primary robot (Robot 1).
		/// </summary>
		public static readonly RobotSystemTypeData Default;

		/// <summary>
		/// Gets the index within the system type (1-based).
		/// </summary>
		public readonly int Index;

		/// <summary>
		/// Gets the system type (Robot, Station, or Application).
		/// </summary>
		public readonly RobotSystemType Type;

		/// <summary>
		/// Gets the combined byte value sent to the controller (Type + Index).
		/// </summary>
		public readonly byte Byte;
	}
}
