//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains progress information for file upload (LoadFile) operations.
	/// Used with the LoadFileProgressDelegate callback to track upload progress.
	/// </summary>
	public class LoadFileProgress {

		/// <summary>
		/// Gets whether the file upload has completed successfully.
		/// </summary>
		public bool Completed { get; }

		/// <summary>
		/// Gets the name of the file being uploaded.
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Gets the total size of the file in bytes.
		/// </summary>
		public int TotalBytes { get; }

		/// <summary>
		/// Gets the number of bytes uploaded so far.
		/// </summary>
		public int LoadedBytes { get; }
	}
}
