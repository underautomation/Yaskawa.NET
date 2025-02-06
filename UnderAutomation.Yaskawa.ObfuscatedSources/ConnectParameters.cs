//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace UnderAutomation.Yaskawa {
	/// <summary>
	/// Contains a set of connection parameters
	/// </summary>
	public class ConnectParameters {

		/// <summary>
		/// Creates a new set of connect parameters
		/// </summary>
		public ConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new set of connect parameters and defines IP property
		/// </summary>
		public ConnectParameters(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Send a ping command before connecting
		/// </summary>
		public bool PingBeforeConnect { get; set; }

		/// <summary>
		/// IP Adress or robot host name
		/// </summary>
		public string IP { get; set; }

		/// <summary>
		/// High Speed Ethernet Server connect parameters
		/// </summary>
		public HighSpeedEServerConnectParameters HighSpeedEServer { get; set; }
	}
}
