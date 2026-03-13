//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace Common {
	/// <summary>
	/// Exception thrown when connection to a Yaskawa robot fails
	/// </summary>
	public class ConnectException : Exception, ISerializable {

		/// <summary>
		/// Name of the protocol that failed to connect
		/// </summary>
		public string Service { get; }

		/// <summary>
		/// Address of the robot (IP:port or serial port name)
		/// </summary>
		public string Address { get; }
	}
}
