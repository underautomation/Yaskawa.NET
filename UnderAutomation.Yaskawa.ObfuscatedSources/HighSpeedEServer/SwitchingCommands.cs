//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the execution mode switching command to send to the robot controller.
	/// These modes control how the robot executes programmed jobs.
	/// </summary>
	public enum SwitchingCommands {

		/// <summary>
		/// Cycle mode - robot executes one complete cycle of the program then stops.
		/// Useful for testing or single-part operations.
		/// </summary>
		Cycle = 1,

		/// <summary>
		/// Step mode - robot executes one instruction at a time, stopping after each.
		/// Useful for debugging and detailed program verification.
		/// </summary>
		Step = 2,

		/// <summary>
		/// Continuous mode - robot executes the program continuously until stopped.
		/// Normal production operation mode.
		/// </summary>
		Continue = 3,
	}
}
