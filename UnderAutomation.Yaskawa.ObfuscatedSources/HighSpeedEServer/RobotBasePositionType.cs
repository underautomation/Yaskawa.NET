//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Defines the type of base position data representation.
	/// </summary>
	public enum RobotBasePositionType : byte {

		/// <summary>
		/// Position is represented as encoder pulse values.
		/// </summary>
		PulseValue = 0,

		/// <summary>
		/// Position is represented in base coordinate system values.
		/// </summary>
		BaseCoordinateValue = 16,
	}
}
