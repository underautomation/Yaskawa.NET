//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Ftp {
	/// <summary>
	/// Represents a file or a folder on the robot controller.
	/// </summary>
	public class FtpListItem {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Full path on the controller (e.g. "/JOB/TEST.JBI").
		/// </summary>
		public string FullName { get; }

		/// <summary>
		/// File or folder name without its path (e.g. "TEST.JBI").
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Date and time of the last modification, as given by the controller.
		/// </summary>
		public DateTime Modified { get; }

		/// <summary>
		/// Indicates whether this item is a file or a folder.
		/// </summary>
		public FtpFileSystemObjectType Type { get; }
	}
}
