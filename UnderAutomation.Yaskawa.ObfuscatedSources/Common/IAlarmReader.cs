//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides access to active alarm information from the robot controller.
	/// </summary>
	public interface IAlarmReader : IYaskawaClient {

		/// <summary>
		/// Reads the currently active alarms from the robot controller.
		/// Returns an array of active alarm entries. Empty array if no alarms are active.
		/// </summary>
		/// <returns>Array of active alarm entries.</returns>
		IAlarmEntry[] GetActiveAlarms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
