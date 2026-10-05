//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;
using System;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains job directory listing data.
	/// Retrieved using the RJDIR command.
	/// </summary>
	public class HostControlJobDirectoryData : HostControlResponse {

		/// <summary>
		/// Gets or sets the list of job names in the directory.
		/// </summary>
		public List<string> JobNames { get; }
	}
}
