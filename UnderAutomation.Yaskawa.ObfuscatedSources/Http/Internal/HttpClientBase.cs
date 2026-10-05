//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.Http.Internal {
	/// <summary>
	/// Base class implementing HTTP communication with Yaskawa robot controllers.
	/// Provides file listing and file content retrieval via the controller's built-in HTTP server.
	/// </summary>
	public abstract class HttpClientBase : IFileReader, IYaskawaClient {

		/// <summary>
		/// Marks the client as disconnected.
		/// </summary>
		public void Close()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the list of files of the specified type available on the robot controller.
		/// </summary>
		/// <param name="fileExtension">The type of files to list.</param>
		/// <returns>An array of file descriptions.</returns>
		public FileDescription[] GetFileList(FileExtension fileExtension)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the content of a file from the robot controller.
		/// The file type is deduced from the file name extension (e.g. "PICK_JOB.JBI" queries /FGET_REQUEST/ROBOT/JOB/PICK_JOB.JBI).
		/// </summary>
		/// <param name="fileName">File name including extension (e.g. "PICK_JOB.JBI", "VAR.DAT").</param>
		/// <returns>The text content of the file.</returns>
		public string GetFile(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected HttpClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Indicates whether the client is configured and ready to communicate.
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Gets the address of the robot controller: an IP address or a host name.
		/// </summary>
		public string Address { get; }

		/// <summary>
		/// Gets the HTTP port number.
		/// </summary>
		public int Port { get; }
	}
}
