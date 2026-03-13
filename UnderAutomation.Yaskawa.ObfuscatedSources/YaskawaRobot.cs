//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using License;
using HighSpeedEServer.Internal;

namespace UnderAutomation.Yaskawa {
	/// <summary>
	/// Main entry point for communicating with Yaskawa Motoman robots.
	/// This class provides methods to connect, monitor, and control the robot through multiple interfaces:
	/// High Speed Ethernet Server
	/// </summary>
	public class YaskawaRobot {

		/// <summary>
		/// Creates a new Yaskawa robot instance
		/// </summary>
		public YaskawaRobot()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot by its IP address.
		/// Establishes connections for High Speed Ethernet Server.
		/// </summary>
		/// <param name="ip">IP or robot host name</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot using the specified parameters.
		/// Establishes connections for High Speed Ethernet Server.
		/// </summary>
		/// <param name="parameters">Connection parameters</param>
		public void Connect(ConnectParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnects all active connections to the robot controller.
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// If you have a license And a key, please call this static method to register the product And exit the trial period
		/// ou can register a product even if the trial period has ended
		/// </summary>
		/// <param name="Licensee">Your organization name</param>
		/// <param name="key">The associated key supplied by UnderAutomation</param>
		/// <returns>Information about the supplied license</returns>
		public static LicenseInfo RegisterLicense(string Licensee, string key)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates whether the High Speed Ethernet Server is currently connected and enabled.
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Access High Speed Ethernet Server features.
		/// Provides high-speed UDP-based communication for real-time robot monitoring and control.
		/// </summary>
		public HighSpeedEServerClientInternal HighSpeedEServer { get; }

		/// <summary>
		/// Return information about your license
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
