//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Represents a single alarm entry with code, sub-code and text description.
	/// </summary>
	public class HostControlAlarmEntry {

		/// <summary>
		/// Gets the alarm code number.
		/// </summary>
		public int Code { get; }

		/// <summary>
		/// Gets the alarm sub-code (data).
		/// </summary>
		public int SubCode { get; }

		/// <summary>
		/// Gets the alarm text message.
		/// </summary>
		public string Message { get; }
	}
}
