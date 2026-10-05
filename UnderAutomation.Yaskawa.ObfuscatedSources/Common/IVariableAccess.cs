//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides typed read/write access to robot controller variables.
	/// </summary>
	public interface IVariableAccess : IYaskawaClient {

		/// <summary>
		/// Reads byte (B) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of byte values.</returns>
		byte[] ReadByte(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes byte (B) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Byte values to write.</param>
		void WriteByte(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads integer (I) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of 16-bit signed integer values.</returns>
		short[] ReadInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes integer (I) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Integer values to write.</param>
		void WriteInteger(int firstIndex, short[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads double integer (D) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of 32-bit signed integer values.</returns>
		int[] ReadDoubleInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes double integer (D) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Double integer values to write.</param>
		void WriteDoubleInteger(int firstIndex, int[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads real (R) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of floating-point values.</returns>
		float[] ReadReal(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes real (R) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Real values to write.</param>
		void WriteReal(int firstIndex, float[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads 16-byte string (S) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of string values.</returns>
		string[] Read16BytesChar(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes 16-byte string (S) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">String values to write.</param>
		void Write16BytesChar(int firstIndex, string[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
