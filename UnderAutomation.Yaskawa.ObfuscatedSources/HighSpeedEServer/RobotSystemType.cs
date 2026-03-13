//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Defines the types of system components that can be queried for information.
	/// </summary>
	public enum RobotSystemType : byte {

		/// <summary>
		/// Robot manipulator system (R1-R8). Valid index: 1-8.
		/// </summary>
		Robot = 10,

		/// <summary>
		/// Station/positioner system (S1-S24). Valid index: 1-24.
		/// </summary>
		Station = 20,

		/// <summary>
		/// Application system (APP1-APP8). Valid index: 1-8.
		/// </summary>
		Application = 100,
	}
}
