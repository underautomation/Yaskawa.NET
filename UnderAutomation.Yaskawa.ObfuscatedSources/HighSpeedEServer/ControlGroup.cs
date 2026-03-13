//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Defines control group types for robot systems.
	/// Control groups organize different motion units within the robot system.
	/// </summary>
	public enum ControlGroup {

		/// <summary>
		/// Robot axes in pulse (encoder) values. Valid index: 1-8.
		/// </summary>
		RobotPulseValue = 0,

		/// <summary>
		/// Base axes in pulse values. Valid index: 1-8.
		/// </summary>
		BasePulseValue = 10,

		/// <summary>
		/// Station axes in pulse values. Valid index: 1-44.
		/// </summary>
		StationPulseValue = 21,

		/// <summary>
		/// Robot axes in Cartesian coordinates. Valid index: 1-8.
		/// </summary>
		RobotCartesian = 100,

		/// <summary>
		/// Base axes in Cartesian coordinates. Valid index: 1-8.
		/// </summary>
		BaseCartesian = 110,
	}
}
