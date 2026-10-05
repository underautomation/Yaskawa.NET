//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Ftp {
	/// <summary>
	/// Connection parameters for FTP communication with the Yaskawa robot controller.
	/// </summary>
	public class FtpConnectParameters {

		/// <summary>
		/// Default FTP port (21).
		/// </summary>
		public const int DEFAULT_PORT = 21;

		/// <summary>
		/// Default timeout in milliseconds for FTP operations (30000ms).
		/// </summary>
		public const int DEFAULT_TIMEOUT_MILLISECONDS = 30000;

		/// <summary>
		/// Initializes a new instance of the FTP connection parameters with default values.
		/// </summary>
		public FtpConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the FTP user name used to authenticate with the robot controller.
		/// 
		/// <p>
		/// Standard accounts:
		/// 
		/// <ul><li><code>rcmaster</code>: widest rights, requires the management mode password.</li><li><code>ftp</code>: standard mode only, accepts any password.</li><li><code>anonymous</code>: standard mode only, accepts any password, download only.</li></ul>
		/// 
		/// If the password protection option is enabled on the controller, only a user defined
		/// in that option is valid. The standard accounts above are then unavailable.
		/// </p>
		/// 
		/// Default: <code>"anonymous"</code>.
		/// </summary>
		public string FtpUser { get; set; }

		/// <summary>
		/// Gets or sets the FTP password associated with <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.FtpUser"/>.
		/// 
		/// <p>
		/// <ul><li>For <code>rcmaster</code>: must be the controller management mode password.</li><li>For <code>ftp</code> or <code>anonymous</code>: any value is accepted (including <code>null</code> or empty).</li><li>If the password protection option is enabled: use the password defined in that option.</li></ul>
		/// </p>
		/// 
		/// Default: <code>null</code>.
		/// </summary>
		public string FtpPassword { get; set; }

		/// <summary>
		/// Gets or sets the FTP port number.
		/// Default: 21.
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Gets or sets the timeout in milliseconds applied to FTP read, connect, and data transfer operations.
		/// Default: 30000ms.
		/// </summary>
		public int TimeoutMilliseconds { get; set; }
	}
}
