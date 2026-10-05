//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides file read operations: download files and list directory contents.
	/// </summary>
	public interface IFileReader : IYaskawaClient {

		/// <summary>
		/// Downloads a file from the robot controller and returns its content as a string.
		/// </summary>
		/// <param name="fileName">Name of the file to download (e.g., "TEST.JBI").</param>
		/// <returns>The text content of the file.</returns>
		string GetFile(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists files matching the specified file extension.
		/// </summary>
		/// <param name="fileExtension">The type of files to list.</param>
		/// <returns>Array of matching file names.</returns>
		string[] GetFileList(FileExtension fileExtension)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists files matching a name pattern.
		/// </summary>
		/// <param name="pattern">File name pattern (e.g., "*.JBI").</param>
		/// <returns>Array of matching file names.</returns>
		string[] GetFileList(string pattern)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
