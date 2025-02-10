//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer.Internal {
	/// <summary>
	/// Represents a set of High Speed Ethernet Server connection parameters
	/// </summary>
	public class HighSpeedEServerConnectParametersBase {


		public HighSpeedEServerConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Maximum time between sending a command and receiving a response (default : 1500ms)
		/// </summary>
		public int DataTimeoutMilliseconds { get; set; }

		/// <summary>
		/// Maximum time between sending the PowerOn() command and its response (default : 8000ms)
		/// </summary>
		public int PowerOnTimeoutMilliseconds { get; set; }

		/// <summary>
		/// Maximum time between sending a file command and receiving a response (default : 4000ms)
		/// </summary>
		public int FileTimeoutMilliseconds { get; set; }

		/// <summary>
		/// UDP port of High Speed EServer data port (default: 10040)
		/// </summary>
		public int DataPort { get; set; }

		/// <summary>
		/// UDP port of High Speed EServer file port (default: 10041)
		/// </summary>
		public int FilePort { get; set; }
	}
}
