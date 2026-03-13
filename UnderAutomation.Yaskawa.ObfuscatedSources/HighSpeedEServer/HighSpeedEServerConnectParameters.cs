//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Base class defining connection parameters for the High Speed Ethernet Server communication.
	/// This class cannot be instantiated directly; use a derived class or use Connect with optional parameters.
	/// Allows customization of timeouts and ports for different network environments.
	/// </summary>
	public class HighSpeedEServerConnectParameters {

		/// <summary>
		/// Default timeout in milliseconds for data commands (1500ms).
		/// </summary>
		public const int DEFAULT_DATA_TIMEOUT_MILLISECONDS = 1500;

		/// <summary>
		/// Default timeout in milliseconds for servo power on operations (8000ms).
		/// </summary>
		public const int DEFAULT_POWER_ON_TIMEOUT_MILLISECONDS = 8000;

		/// <summary>
		/// Default timeout in milliseconds for file operations (4000ms).
		/// </summary>
		public const int DEFAULT_FILE_TIMEOUT_MILLISECONDS = 4000;

		/// <summary>
		/// Default UDP port for data communication (10040).
		/// </summary>
		public const int DEFAULT_DATA_PORT = 10040;

		/// <summary>
		/// Default UDP port for file transfer operations (10041).
		/// </summary>
		public const int DEFAULT_FILE_PORT = 10041;

		/// <summary>
		/// Initializes a new instance of the connection parameters class.
		/// </summary>
		public HighSpeedEServerConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for a response to data commands.
		/// Applies to most read/write operations like position reading, variable access, etc.
		/// Default: 1500ms.
		/// </summary>
		public int DataTimeoutMilliseconds { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for servo power on to complete.
		/// Servo power on may take longer due to brake release and motor initialization.
		/// Default: 8000ms.
		/// </summary>
		public int PowerOnTimeoutMilliseconds { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for file operation responses.
		/// File operations may be slower due to larger data transfers and disk I/O on the controller.
		/// Default: 4000ms.
		/// </summary>
		public int FileTimeoutMilliseconds { get; set; }

		/// <summary>
		/// Gets or sets the UDP port number for data communication.
		/// Must match the robot controller's High Speed Ethernet Server data port configuration.
		/// Default: 10040.
		/// </summary>
		public int DataPort { get; set; }

		/// <summary>
		/// Gets or sets the UDP port number for file transfer operations.
		/// Must match the robot controller's High Speed Ethernet Server file port configuration.
		/// Default: 10041.
		/// </summary>
		public int FilePort { get; set; }
	}
}
