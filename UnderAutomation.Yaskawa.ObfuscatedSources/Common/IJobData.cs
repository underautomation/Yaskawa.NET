//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents information about the currently executing job on a Yaskawa robot controller.
	/// </summary>
	public interface IJobData {

		/// <summary>
		/// Name of the current job.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Current line number being executed.
		/// </summary>
		int Line { get; }

		/// <summary>
		/// Current step number being executed.
		/// </summary>
		int Step { get; }
	}
}
