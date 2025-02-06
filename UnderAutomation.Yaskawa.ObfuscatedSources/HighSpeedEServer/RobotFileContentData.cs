//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;

namespace HighSpeedEServer {

	public class RobotFileContentData : RobotData {


		public List<RobotDataHeader> Headers { get; set; }


		public string Content { get; set; }


		public string FileName { get; set; }


		public int GetParam(string section, int parameterLine, int parameterColumn)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
