//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.HostControl.Internal;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Base class defining Ethernet Server (TCP) connection parameters for the Host Control communication.
	/// This class provides configuration for TCP-based communication with YRC1000 controllers.
	/// </summary>
	public class EServerConnectParameters : HostControlConnectParametersBase {

		/// <summary>
		/// Default TCP port for Ethernet Server communication (80).
		/// </summary>
		public const int DEFAULT_PORT = 80;

		/// <summary>
		/// Initializes a new instance of the Ethernet Server connection parameters.
		/// </summary>
		public EServerConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the TCP port number for Ethernet Server communication.
		/// Must match the robot controller's Ethernet Server port configuration.
		/// Default: 80.
		/// </summary>
		public int Port { get; set; }
	}
}
