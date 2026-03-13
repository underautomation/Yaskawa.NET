//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the coordinate system for position command interpretation.
	/// Determines how X, Y, Z, Rx, Ry, Rz values are interpreted.
	/// </summary>
	public enum PositionCommandOperationCoordinate {

		/// <summary>
		/// Base coordinate system (world frame at robot base).
		/// Fixed reference frame typically aligned with robot mounting.
		/// </summary>
		Base = 16,

		/// <summary>
		/// Robot coordinate system.
		/// Reference frame at the robot's origin point.
		/// </summary>
		Robot = 17,

		/// <summary>
		/// User-defined coordinate system.
		/// Custom reference frame defined for specific workpiece or fixture.
		/// </summary>
		User = 18,

		/// <summary>
		/// Tool coordinate system.
		/// Reference frame at the tool center point (TCP).
		/// </summary>
		Tool = 19,
	}
}
