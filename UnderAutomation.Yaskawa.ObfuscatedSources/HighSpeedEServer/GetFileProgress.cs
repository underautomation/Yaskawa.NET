//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains progress information for file download (GetFile) operations.
	/// Used with the GetFileProgressDelegate callback to track download progress.
	/// </summary>
	public class GetFileProgress {

		/// <summary>
		/// Gets whether the file download has completed successfully.
		/// </summary>
		public bool Completed { get; }

		/// <summary>
		/// Gets the name of the file being downloaded.
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Gets the number of bytes downloaded so far.
		/// </summary>
		public int DownloadedBytes { get; }
	}
}
