//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides file write and delete operations on the robot controller.
	/// </summary>
	public interface IFileWriter : IYaskawaClient {

		/// <summary>
		/// Uploads a file to the robot controller.
		/// </summary>
		/// <param name="fileName">Name of the file to create or overwrite (e.g., "TEST.JBI").</param>
		/// <param name="content">The text content of the file.</param>
		void LoadFile(string fileName, string content)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a file from the robot controller.
		/// </summary>
		/// <param name="fileName">Name of the file to delete (e.g., "TEST.JBI").</param>
		void DeleteFile(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
