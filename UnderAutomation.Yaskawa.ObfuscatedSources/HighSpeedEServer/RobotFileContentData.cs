//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;

namespace UnderAutomation.Yaskawa.HighSpeedEServer {
	/// <summary>
	/// Contains the content of a file downloaded from the robot controller.
	/// Provides methods for parsing structured file content such as job files and parameter files.
	/// </summary>
	public class RobotFileContentData : RobotData {

		/// <summary>
		/// Extracts an integer parameter value from a structured file section.
		/// Useful for reading values from parameter files and job data.
		/// </summary>
		/// <param name="section">The section name without the "///" prefix (e.g., "INST", "POS").</param>
		/// <param name="parameterLine">Zero-based line number within the section.</param>
		/// <param name="parameterColumn">Zero-based column number (comma-separated values).</param>
		/// <returns>The integer value at the specified location.</returns>
		public int GetParam(string section, int parameterLine, int parameterColumn)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the list of response headers from multi-block transfers.
		/// Large files are transferred in multiple UDP packets.
		/// </summary>
		public List<RobotDataHeader> Headers { get; }

		/// <summary>
		/// Gets the text content of the downloaded file.
		/// </summary>
		public string Content { get; }

		/// <summary>
		/// Gets the text content of the downloaded file.
		/// </summary>
		public byte[] ContentRaw { get; }

		/// <summary>
		/// Gets the name of the downloaded file.
		/// </summary>
		public string FileName { get; }
	}
}
