//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains information about a robot alarm retrieved from the controller.
	/// Alarms indicate error conditions that may require operator intervention.
	/// </summary>
	public class RobotAlarmData : RobotData {

		/// <summary>
		/// Gets the alarm code identifying the specific alarm type.
		/// Alarm codes are documented in the robot's maintenance manual.
		/// </summary>
		public int Code { get; }

		/// <summary>
		/// Gets additional alarm data providing context about the alarm.
		/// The meaning depends on the specific alarm code.
		/// </summary>
		public int Data { get; }

		/// <summary>
		/// Gets the alarm type/category classification.
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Gets the timestamp when the alarm occurred.
		/// Format: "YYYY/MM/DD HH:MM:SS" (16 characters).
		/// </summary>
		public string OccurringTime { get; }

		/// <summary>
		/// Gets the alarm message text describing the alarm condition.
		/// Maximum 32 characters.
		/// </summary>
		public string Text { get; }
	}
}
