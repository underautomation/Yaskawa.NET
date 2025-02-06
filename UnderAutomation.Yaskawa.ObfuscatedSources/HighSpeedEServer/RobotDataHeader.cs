//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Net;

namespace HighSpeedEServer {

	public class RobotDataHeader {


		public IPEndPoint IP { get; set; }


		public int DataSize { get; set; }


		public int BlockNo { get; set; }


		public bool IsLastBlock { get; }
	}
}
