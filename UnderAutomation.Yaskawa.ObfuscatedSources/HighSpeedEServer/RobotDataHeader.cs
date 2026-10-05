//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Net;

namespace UnderAutomation.Yaskawa.HighSpeedEServer {
	/// <summary>
	/// Information about a response of the robot controller: the controller that answered, the size of the data, and the state of a transfer in several parts.
	/// </summary>
	public class RobotDataHeader {


		public RobotDataHeader()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the IP endpoint (address and port) of the robot controller that sent the response.
		/// Useful for identifying the source in multi-robot configurations.
		/// </summary>
		public IPEndPoint IP { get; }

		/// <summary>
		/// Gets the size, in bytes, of the data returned by the controller in this response.
		/// </summary>
		public int DataSize { get; }

		/// <summary>
		/// Gets the raw block number of a transfer in several parts, such as a file transfer.
		/// Use <see cref="UnderAutomation.Yaskawa.HighSpeedEServer.RobotDataHeader.IsLastBlock"/> to know if this response is the last part.
		/// </summary>
		public int BlockNo { get; }

		/// <summary>
		/// Gets a value indicating whether this response is the last part of a transfer in several parts.
		/// </summary>
		public bool IsLastBlock { get; }
	}
}
