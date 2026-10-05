//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Exception thrown when a Host Control command fails.
	/// </summary>
	public class HostControlException : Exception, ISerializable {

		/// <summary>
		/// Creates a new HostControlException with the specified message.
		/// </summary>
		/// <param name="message">The error message.</param>
		public HostControlException(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new HostControlException with the specified message and error code.
		/// </summary>
		/// <param name="message">The error message.</param>
		/// <param name="errorCode">The error code from the robot controller.</param>
		public HostControlException(string message, string errorCode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new HostControlException with the specified message, command, and error code.
		/// </summary>
		/// <param name="message">The error message.</param>
		/// <param name="command">The command that caused the exception.</param>
		/// <param name="errorCode">The error code from the robot controller.</param>
		public HostControlException(string message, string command, string errorCode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new HostControlException with the specified message and inner exception.
		/// </summary>
		/// <param name="message">The error message.</param>
		/// <param name="innerException">The inner exception.</param>
		public HostControlException(string message, Exception innerException)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the error code returned by the robot controller.
		/// </summary>
		public string ErrorCode { get; }

		/// <summary>
		/// Gets the command that caused the exception.
		/// </summary>
		public string Command { get; }
	}
}
