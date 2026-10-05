//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace UnderAutomation.Yaskawa.Ftp {
	/// <summary>
	/// Exception thrown when an FTP operation on the Yaskawa controller fails.
	/// The message explains the cause and, when the logged user does not have enough rights, which user to use.
	/// </summary>
	public class FtpException : Exception, ISerializable {

		/// <summary>
		/// Operation that failed.
		/// </summary>
		public FtpOperation Operation { get; }

		/// <summary>
		/// Reason of the failure.
		/// </summary>
		public FtpErrorReason Reason { get; }

		/// <summary>
		/// Path of the file on the controller concerned by the operation. Null for connection and listing errors.
		/// </summary>
		public string RemotePath { get; }

		/// <summary>
		/// FTP user name that was logged when the error occurred.
		/// </summary>
		public string User { get; }

		/// <summary>
		/// FTP reply code returned by the controller (e.g. 550). 0 if the controller did not reply.
		/// </summary>
		public int ReplyCode { get; }

		/// <summary>
		/// Raw reply text returned by the controller. Null if the controller did not reply.
		/// </summary>
		public string ReplyMessage { get; }
	}
}
