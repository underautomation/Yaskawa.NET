//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents an active alarm on a Yaskawa robot controller.
	/// </summary>
	public interface IAlarmEntry {

		/// <summary>
		/// Alarm code identifying the alarm type.
		/// </summary>
		int Code { get; }

		/// <summary>
		/// Alarm sub-code providing additional context.
		/// </summary>
		int SubCode { get; }

		/// <summary>
		/// Human-readable alarm message text.
		/// </summary>
		string Message { get; }

		/// <summary>
		/// Timestamp of alarm occurrence (format depends on protocol).
		/// </summary>
		string OccurringTime { get; }
	}
}
