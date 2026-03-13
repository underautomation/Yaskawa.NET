//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;

namespace HighSpeedEServer {
	/// <summary>
	/// Contains the result of a file listing operation on the robot controller.
	/// Returns an array of file names matching the specified pattern.
	/// </summary>
	public class RobotFileListData : RobotData {

		/// <summary>
		/// Gets the list of response headers from multi-block transfers.
		/// File listings may span multiple UDP packets for large directories.
		/// </summary>
		public List<RobotDataHeader> Headers { get; }

		/// <summary>
		/// Gets the array of file names returned by the listing operation.
		/// File names include extensions (e.g., "MYJOB.JBI", "SYSTEM.SYS").
		/// </summary>
		public string[] Files { get; }
	}
}
