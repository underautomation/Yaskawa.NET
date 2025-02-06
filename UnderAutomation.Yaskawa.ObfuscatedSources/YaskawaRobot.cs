//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using HighSpeedEServer.Internal;

namespace UnderAutomation.Yaskawa {

	public class YaskawaRobot {

		/// <summary>
		/// Creates a new Yaskawa robot instance
		/// </summary>
		public YaskawaRobot()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot by its IP adress
		/// </summary>
		/// <param name="ip">IP or robot host name</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot
		/// </summary>
		/// <param name="parameters">Connection parameters</param>
		public void Connect(ConnectParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Access High Speed Ethernet Server features
		/// </summary>
		public HighSpeedEServerClientInternal HighSpeedEServer { get; }

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
		/// Return information about your license
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
