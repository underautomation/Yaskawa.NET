//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains I/O signal data.
	/// </summary>
	public class HostControlIOData : HostControlResponse {

		/// <summary>
		/// Gets the bit value at the specified offset from the start address.
		/// </summary>
		/// <param name="bitOffset">The bit offset from the start address (0-based).</param>
		/// <returns>True if the bit is set, false otherwise.</returns>
		public bool GetBit(int bitOffset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets or sets the starting I/O contact number.
		/// </summary>
		public int StartAddress { get; }

		/// <summary>
		/// Gets or sets the number of I/O bytes read.
		/// </summary>
		public int Count { get; }

		/// <summary>
		/// Gets or sets the I/O data bytes.
		/// </summary>
		public byte[] Data { get; }
	}
}
