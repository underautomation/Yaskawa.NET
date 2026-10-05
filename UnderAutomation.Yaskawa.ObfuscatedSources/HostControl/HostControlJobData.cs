//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains information about the currently executing job (program).
	/// Retrieved using the RJSEQ command.
	/// </summary>
	public class HostControlJobData : HostControlResponse, IJobData {

		/// <summary>
		/// Gets or sets the name of the currently executing job.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets or sets the current line number within the job (0-9999).
		/// </summary>
		public int Line { get; }

		/// <summary>
		/// Gets or sets the current step number within the job (1-9998).
		/// </summary>
		public int Step { get; }
	}
}
