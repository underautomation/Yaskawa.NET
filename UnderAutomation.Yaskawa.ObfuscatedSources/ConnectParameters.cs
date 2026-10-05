//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.HighSpeedEServer.Internal;
using UnderAutomation.Yaskawa.HostControl.Internal;
using UnderAutomation.Yaskawa.Http.Internal;
using UnderAutomation.Yaskawa.Ftp.Internal;

namespace UnderAutomation.Yaskawa {
	/// <summary>
	/// Contains a set of connection parameters for robot communication.
	/// Supports High Speed Ethernet Server and Host Control protocols.
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
		public HighSpeedEServerConnectParametersInternal HighSpeedEServer { get; set; }

		/// <summary>
		/// Ethernet Server connect parameters.
		/// Used for TCP-based Host Control communication via Ethernet Server.
		/// </summary>
		public EServerConnectParametersInternal EServer { get; set; }

		/// <summary>
		/// HTTP connect parameters.
		/// Used for file listing and file content retrieval via the robot's built-in web server.
		/// </summary>
		public HttpConnectParametersInternal Http { get; set; }

		/// <summary>
		/// FTP connect parameters.
		/// Used for file upload, download, listing and management via the robot's built-in FTP server.
		/// </summary>
		public FtpConnectParametersInternal Ftp { get; set; }
	}
}
