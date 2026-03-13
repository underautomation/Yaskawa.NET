//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains system information about the robot controller including software version and configuration.
	/// Retrieved using the system information acquiring command.
	/// </summary>
	public class RobotSystemInformation : RobotData {

		/// <summary>
		/// Returns a string representation of the system information.
		/// </summary>
		/// <returns>A multi-line string containing software version, name, and parameter information.</returns>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the controller software version string.
		/// Format typically includes model and version number. Maximum 24 characters.
		/// </summary>
		public string SoftwareVersion { get; }

		/// <summary>
		/// Gets the system/robot name or model identifier.
		/// Maximum 16 characters.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets parameter file or configuration information.
		/// Maximum 8 characters.
		/// </summary>
		public string Parameter { get; }
	}
}
