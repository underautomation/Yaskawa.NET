//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains the job call stack for a specific task on the robot controller.
	/// Represents the current nesting of CALL instructions, from the outermost job to the currently executing one.
	/// Only supported on DX200 (AY/BY/YN) controllers.
	/// </summary>
	public class RobotJobStackData : RobotData {

		/// <summary>
		/// Gets the job names in the call stack, outermost first.
		/// The first entry is the root job, the last entry is the currently executing job.
		/// Empty if no nested calls are active.
		/// </summary>
		public string[] Jobs { get; }
	}
}
