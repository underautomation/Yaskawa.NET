//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Ftp.Internal {
	/// <summary>
	/// FTP connection parameters with an enable flag, used by <see cref="UnderAutomation.Yaskawa.ConnectParameters"/>.
	/// </summary>
	public class FtpConnectParametersInternal : FtpConnectParameters {


		public FtpConnectParametersInternal()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets a value indicating whether to establish an FTP connection when calling
		/// <see cref="UnderAutomation.Yaskawa.YaskawaRobot.Connect(UnderAutomation.Yaskawa.ConnectParameters)"/>.
		/// Default: false.
		/// </summary>
		public bool Enable { get; set; }
	}
}
