//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains management time information for tracking robot operation statistics.
	/// Provides uptime and usage metrics for maintenance planning and reporting.
	/// </summary>
	public class RobotManagementTimeData : RobotData {

		/// <summary>
		/// Gets the start time of the tracked period.
		/// Format: "YYYY/MM/DD HH:MM" (16 characters).
		/// </summary>
		public string StartTime { get; }

		/// <summary>
		/// Gets the elapsed time for the tracked metric.
		/// Format: "HHHH:MM:SS.ss" or similar time duration format (12 characters).
		/// </summary>
		public string EllapseTime { get; }
	}
}
