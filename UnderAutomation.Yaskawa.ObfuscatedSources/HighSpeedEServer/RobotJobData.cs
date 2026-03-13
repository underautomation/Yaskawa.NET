//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains information about the currently executing job (program) on the robot controller.
	/// Retrieved using the executing job information reading command.
	/// </summary>
	public class RobotJobData : RobotData {

		/// <summary>
		/// Gets the name of the currently selected/executing job.
		/// Job names can be up to 32 characters. Returns empty string if no job is selected.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets the current line number being executed within the job.
		/// Line numbers are 1-based and correspond to the job listing.
		/// </summary>
		public int Line { get; }

		/// <summary>
		/// Gets the current step number within the job.
		/// Step numbers track the execution progress through motion instructions.
		/// </summary>
		public int Step { get; }

		/// <summary>
		/// Gets the current speed override percentage (0-100).
		/// This is the global speed multiplier applied to all motions.
		/// </summary>
		public double SpeedOverride { get; }
	}
}
