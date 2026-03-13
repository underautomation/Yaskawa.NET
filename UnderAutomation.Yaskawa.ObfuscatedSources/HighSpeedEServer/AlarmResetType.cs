//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the type of alarm reset operation to perform.
	/// </summary>
	public enum AlarmResetType {

		/// <summary>
		/// Reset the current alarm. Requires the alarm condition to be resolved.
		/// </summary>
		Reset = 1,

		/// <summary>
		/// Cancel the current error. Used for recoverable errors.
		/// </summary>
		Cancel = 2,
	}
}
