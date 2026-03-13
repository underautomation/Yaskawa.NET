//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using HighSpeedEServer.Internal;

namespace HighSpeedEServer {
	/// <summary>
	/// Main client class for communicating with Yaskawa Motoman industrial robots using the High Speed Ethernet Server protocol.
	/// This class provides methods for reading robot status, positions, variables, and controlling robot operations via UDP.
	/// </summary>
	public class HighSpeedEServerClient : HighSpeedEServerClientBase {

		/// <summary>
		/// Creates a new instance of HighSpeedEServerClient for robot communication.
		/// Call Connect() to establish communication with a robot controller.
		/// </summary>
		public HighSpeedEServerClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to a robot controller with custom connection parameters object.
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller.</param>
		/// <param name="parameters">Connection parameters including ports and timeouts.</param>
		public void Connect(string ip, HighSpeedEServerConnectParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
