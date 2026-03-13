//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the speed classification (units) for motion commands.
	/// Determines how the speed value is interpreted by the controller.
	/// </summary>
	public enum PositionCommandClassification {

		/// <summary>
		/// Speed as percentage of maximum link (joint) speed.
		/// Valid range: 0.01 to 100.00 percent.
		/// </summary>
		LinkPercent = 0,

		/// <summary>
		/// Speed in millimeters per second for linear motion.
		/// Valid range depends on robot model.
		/// </summary>
		Cartesian_MM_S = 1,

		/// <summary>
		/// Speed in degrees per second for rotational motion.
		/// Valid range depends on robot model.
		/// </summary>
		Cartesian_DEG_S = 2,
	}
}
