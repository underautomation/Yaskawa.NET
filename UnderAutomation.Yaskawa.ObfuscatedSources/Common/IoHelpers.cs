//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Helper methods for handling Yaskawa I/O group conversions and related utilities.
	/// </summary>
	public static class IoHelpers {

		/// <summary>
		/// Converts an I/O group address (type + group + bit) to a flat Yaskawa 5-digit contact number.
		/// </summary>
		/// <param name="type">The I/O signal category.</param>
		/// <param name="group">1-based group number within the I/O type.</param>
		/// <param name="bitIndex">Bit index within the group (0–7).</param>
		/// <returns>The flat contact number (bit address).</returns>
		public static uint ConvertIOGroupToBitAddress(IOType type, ushort group, byte bitIndex)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
