//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents the file types available on a Yaskawa robot controller.
	/// </summary>
	public enum FileExtension {

		/// <summary>
		/// Job files (.JBI)
		/// </summary>
		JOB = 0,

		/// <summary>
		/// Data files (.DAT)
		/// </summary>
		DAT = 1,

		/// <summary>
		/// Condition files (.CND)
		/// </summary>
		CND = 2,

		/// <summary>
		/// System files (.SYS)
		/// </summary>
		SYS = 3,

		/// <summary>
		/// Parameter files (.PRM)
		/// </summary>
		PRM = 4,

		/// <summary>
		/// List files (.LST)
		/// </summary>
		LST = 5,

		/// <summary>
		/// CSV files (.CSV)
		/// </summary>
		CSV = 6,

		/// <summary>
		/// Log files (.LOG)
		/// </summary>
		LOG = 7,

		/// <summary>
		/// Text files (.TXT)
		/// </summary>
		TXT = 8,
	}
}
