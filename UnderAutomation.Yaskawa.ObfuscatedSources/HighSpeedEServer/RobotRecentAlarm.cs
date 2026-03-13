//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies which recent alarm to retrieve from the robot controller.
	/// The controller maintains a history of the most recent alarms.
	/// </summary>
	public enum RobotRecentAlarm {

		/// <summary>
		/// The most recent (current) alarm.
		/// </summary>
		Latest = 1,

		/// <summary>
		/// The second most recent alarm.
		/// </summary>
		SecondLatest = 2,

		/// <summary>
		/// The third most recent alarm.
		/// </summary>
		ThirdLatest = 3,

		/// <summary>
		/// The fourth most recent alarm.
		/// </summary>
		FourthLatest = 4,
	}
}
