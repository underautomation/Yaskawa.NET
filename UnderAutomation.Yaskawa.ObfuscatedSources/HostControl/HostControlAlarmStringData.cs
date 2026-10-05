//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains alarm information with text messages retrieved from the robot controller.
	/// </summary>
	public class HostControlAlarmStringData : HostControlResponse {

		/// <summary>
		/// Gets the number of active alarms (entries of <see cref="UnderAutomation.Yaskawa.HostControl.HostControlAlarmStringData.Alarms"/> with a code other than 0).
		/// </summary>
		public int AlarmCount { get; }

		/// <summary>
		/// Gets the active error. Its code is 0 when no error is active.
		/// </summary>
		public HostControlAlarmEntry Error { get; }

		/// <summary>
		/// Gets the alarm entries with codes and text messages (always 4 entries, the code of an unused entry is 0).
		/// </summary>
		public HostControlAlarmEntry[] Alarms { get; }
	}
}
