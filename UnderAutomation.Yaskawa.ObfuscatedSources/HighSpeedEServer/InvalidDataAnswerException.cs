//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace HighSpeedEServer {
	/// <summary>
	/// Exception thrown when the robot controller returns an error response to a High Speed Ethernet Server command.
	/// This exception contains detailed status codes that help identify the specific error condition.
	/// </summary>
	public class InvalidDataAnswerException : Exception, ISerializable {

		/// <summary>
		/// Gets the primary status code returned by the robot controller.
		/// A value of 0 indicates success; any other value indicates an error condition.
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Gets the additional status code providing more detailed error information.
		/// The interpretation of this value depends on the primary Status code.
		/// </summary>
		public int AddedStatus { get; }
	}
}
