//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains system time information from the robot controller.
	/// Retrieved using the RSYSTM command.
	/// </summary>
	public class HostControlSystemTimeData : HostControlResponse {

		/// <summary>
		/// Gets the year.
		/// </summary>
		public string Year { get; }

		/// <summary>
		/// Gets the month and day (MM/DD format).
		/// </summary>
		public string MonthDay { get; }

		/// <summary>
		/// Gets the hour and minute (HH:MM format).
		/// </summary>
		public string HourMinute { get; }

		/// <summary>
		/// Gets the second.
		/// </summary>
		public string Second { get; }

		/// <summary>
		/// Gets the day of the week.
		/// </summary>
		public string DayOfWeek { get; }
	}
}
