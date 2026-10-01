//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Defines the coordinate system type for position data.
	/// </summary>
	public enum RobotPositionDataType {

		/// <summary>
		/// Position in encoder pulse values (joint space).
		/// </summary>
		PulseValue = 0,

		/// <summary>
		/// Position in base coordinate system (world frame, value 16).
		/// </summary>
		BaseCoordinateValue = 16,

		/// <summary>
		/// Position in robot coordinate system (robot base frame, value 17).
		/// </summary>
		RobotCoordinateValue = 17,

		/// <summary>
		/// Position in tool coordinate system (value 18).
		/// </summary>
		ToolCoordinateValue = 18,

		/// <summary>
		/// Position in user-defined coordinate system (value 19).
		/// </summary>
		UserCoordinateValue = 19,
	}
}
