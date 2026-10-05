//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.License;
using UnderAutomation.Yaskawa.HighSpeedEServer.Internal;
using UnderAutomation.Yaskawa.HostControl.Internal;
using UnderAutomation.Yaskawa.Http.Internal;
using UnderAutomation.Yaskawa.Ftp.Internal;

namespace UnderAutomation.Yaskawa {
	/// <summary>
	/// Main entry point for communicating with Yaskawa Motoman robots.
	/// This class provides methods to connect, monitor, and control the robot through multiple interfaces:
	/// High Speed Ethernet Server, Ethernet Server (Host Control over TCP), HTTP and FTP.
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
		/// Establishes the connection of each protocol enabled by default in <see cref="UnderAutomation.Yaskawa.ConnectParameters"/>.
		/// </summary>
		/// <param name="ip">IP or robot host name</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot using the specified parameters.
		/// Establishes the connection of each protocol enabled in the parameters.
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
		/// Indicates whether any communication interface (High Speed Ethernet Server, Ethernet Server, HTTP or FTP) is currently connected.
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Access High Speed Ethernet Server features.
		/// Provides high-speed UDP-based communication for real-time robot monitoring and control.
		/// </summary>
		public HighSpeedEServerClientInternal HighSpeedEServer { get; }

		/// <summary>
		/// Access Host Control features via Ethernet Server (TCP).
		/// Supports YRC1000 and compatible controllers.
		/// Connected automatically when calling Connect() with EServer.Enable = true.
		/// </summary>
		public EServerClientInternal EServer { get; }

		/// <summary>
		/// Access HTTP features for file listing and file content retrieval.
		/// Communicates with the robot controller's built-in web server.
		/// Connected automatically when calling Connect() with Http.Enable = true.
		/// </summary>
		public HttpClientInternal Http { get; }

		/// <summary>
		/// Access FTP features for file upload, download, listing, and management.
		/// Communicates with the robot controller's built-in FTP server.
		/// Connected automatically when calling Connect() with Ftp.Enable = true.
		/// </summary>
		public FtpClientInternal Ftp { get; }

		/// <summary>
		/// Return information about your license
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
