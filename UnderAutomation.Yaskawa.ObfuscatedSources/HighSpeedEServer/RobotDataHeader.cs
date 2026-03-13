//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Net;

namespace HighSpeedEServer {
	/// <summary>
	/// Contains header information extracted from a High Speed Ethernet Server response packet.
	/// Provides metadata about the communication including source address, data size, and transfer status.
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
		/// Gets the size of the data payload in the response packet.
		/// Does not include the header size.
		/// </summary>
		public int DataSize { get; }

		/// <summary>
		/// Gets the block number for multi-block transfers.
		/// The most significant bit (0x80000000) indicates this is the last block.
		/// Used primarily for file transfer operations.
		/// </summary>
		public int BlockNo { get; }

		/// <summary>
		/// Gets a value indicating whether this is the last block in a multi-block transfer.
		/// Returns true when the MSB of BlockNo is set (0x80000000).
		/// </summary>
		public bool IsLastBlock { get; }
	}
}
