//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Ftp {
	/// <summary>
	/// Reason why an FTP operation failed.
	/// </summary>
	public enum FtpErrorReason {

		/// <summary>
		/// The controller refused the operation for another reason. See <see cref="UnderAutomation.Yaskawa.Ftp.FtpException.ReplyMessage"/>.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The user name or the password is not accepted by the controller.
		/// </summary>
		LoginIncorrect = 1,

		/// <summary>
		/// The logged user does not have the right to do this operation on this file.
		/// </summary>
		AccessDenied = 2,

		/// <summary>
		/// The file does not exist on the controller.
		/// </summary>
		FileNotFound = 3,

		/// <summary>
		/// The job already exists on the controller. The controller does not overwrite a job by FTP.
		/// </summary>
		JobAlreadyExists = 4,

		/// <summary>
		/// The controller refused to delete the file.
		/// </summary>
		DeleteRefused = 5,

		/// <summary>
		/// The connection with the controller was lost or timed out.
		/// </summary>
		ConnectionError = 6,
	}
}
