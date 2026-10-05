//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides read/write access to robot I/O signals.
	/// </summary>
	public interface IIOAccess : IYaskawaClient {

		/// <summary>
		/// Reads I/O signal bytes from the robot controller. Each byte holds a group of 8 signals.
		/// </summary>
		/// <param name="startAddress">I/O index of the first group: contact number divided by 10
		///             (1 for #00010, 1001 for #10010, 2701 for #27010).</param>
		/// <param name="count">Number of bytes to read.</param>
		/// <returns>Array of I/O byte values.</returns>
		byte[] ReadIO(int startAddress, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes I/O signal bytes to the robot controller. Each byte holds a group of 8 signals.
		/// </summary>
		/// <param name="startAddress">I/O index of the first group: contact number divided by 10
		///             (2701 for #27010).</param>
		/// <param name="data">Data bytes to write.</param>
		void WriteIO(int startAddress, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
