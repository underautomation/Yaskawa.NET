//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains alarm information retrieved from the robot controller.
	/// </summary>
	public class HostControlAlarmData : HostControlResponse {

		/// <summary>
		/// Gets the codes (5 entries). Index 0 is the code of the active error, indexes 1 to 4 are the codes of the active alarms.
		/// A code of 0 means no error or no alarm.
		/// </summary>
		public int[] Codes { get; }

		/// <summary>
		/// Gets the sub-codes (5 entries), at the same index as <see cref="UnderAutomation.Yaskawa.HostControl.HostControlAlarmData.Codes"/>.
		/// Index 0 is the sub-code of the error, indexes 1 to 4 are the data of the alarms.
		/// </summary>
		public int[] Data { get; }
	}
}
