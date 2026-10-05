//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Default implementation of <see cref="UnderAutomation.Yaskawa.Common.IAlarmEntry"/>.
	/// </summary>
	public class AlarmEntry : IAlarmEntry {

		/// <summary>
		/// Returns a string representation of this alarm entry.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public AlarmEntry()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Alarm code identifying the alarm type.
		/// </summary>
		public int Code { get; }

		/// <summary>
		/// Alarm sub-code providing additional context.
		/// </summary>
		public int SubCode { get; }

		/// <summary>
		/// Human-readable alarm message text.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Timestamp of alarm occurrence (format depends on protocol).
		/// </summary>
		public string OccurringTime { get; }
	}
}
