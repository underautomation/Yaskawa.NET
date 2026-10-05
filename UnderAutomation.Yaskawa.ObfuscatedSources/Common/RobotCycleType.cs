//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Specifies the execution cycle type.
	/// </summary>
	public enum RobotCycleType {

		/// <summary>
		/// Step mode : execute one instruction at a time.
		/// </summary>
		Step = 1,

		/// <summary>
		/// One cycle mode : execute one complete cycle then stop.
		/// </summary>
		OneCycle = 2,

		/// <summary>
		/// Automatic mode : continuous operation.
		/// </summary>
		Automatic = 3,
	}
}
