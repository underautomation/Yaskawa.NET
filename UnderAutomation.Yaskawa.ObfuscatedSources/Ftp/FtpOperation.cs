//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Ftp {
	/// <summary>
	/// FTP operation that was running when an <see cref="UnderAutomation.Yaskawa.Ftp.FtpException"/> was thrown.
	/// </summary>
	public enum FtpOperation {

		/// <summary>
		/// Connection and login to the controller.
		/// </summary>
		Connect = 0,

		/// <summary>
		/// Listing of files or folders.
		/// </summary>
		List = 1,

		/// <summary>
		/// File download from the controller.
		/// </summary>
		Download = 2,

		/// <summary>
		/// File upload to the controller.
		/// </summary>
		Upload = 3,

		/// <summary>
		/// File deletion on the controller.
		/// </summary>
		Delete = 4,
	}
}
