//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Specifies the speed type for motion commands.
	/// </summary>
	public enum HostControlSpeedType {

		/// <summary>
		/// Speed is specified as a percentage of maximum speed (V).
		/// </summary>
		Percentage = 0,

		/// <summary>
		/// Speed is specified in mm/s (VE).
		/// </summary>
		MillimetersPerSecond = 1,
	}
}
