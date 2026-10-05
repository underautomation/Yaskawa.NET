//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.IO;

namespace UnderAutomation.Yaskawa.Ftp.Internal {
	/// <summary>
	/// Abstract base class that implements FTP communication with a Yaskawa robot controller.
	/// Provides file management (upload, download, list, delete) via the controller's FTP server.
	/// </summary>
	public abstract class FtpClientBase : IFileManager, IFileReader, IFileWriter, IYaskawaClient {

		/// <summary>
		/// Closes the connection to the robot controller and releases resources.
		/// </summary>
		public void Close()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Downloads a text file from the robot controller and returns its content.
		/// </summary>
		/// <param name="fileName">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <returns>The text content of the file.</returns>
		public string GetFile(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists the files of the specified type on the controller.
		/// </summary>
		/// <param name="fileExtension">Type of files to list.</param>
		/// <returns>Array of file names (e.g. "TEST.JBI").</returns>
		public string[] GetFileList(FileExtension fileExtension)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists the files whose names match the specified pattern.
		/// When the pattern has a known extension (e.g. "*.JBI"), only the matching folder is listed.
		/// Otherwise, all folders of the controller are listed.
		/// </summary>
		/// <param name="pattern">File name pattern, with '*' and '?' wildcards (e.g. "*.JBI", "VISION*.JBI", "/DAT/*.DAT").</param>
		/// <returns>Array of matching file names (e.g. "TEST.JBI").</returns>
		public string[] GetFileListByPattern(string pattern)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a text file from the robot controller and returns its content (asynchronous).
		/// </summary>
		/// <param name="fileName">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>The text content of the file.</returns>
		public Task<string> GetFileAsync(string fileName, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists the files of the specified type on the controller (asynchronous).
		/// </summary>
		/// <param name="fileExtension">Type of files to list.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Array of file names (e.g. "TEST.JBI").</returns>
		public Task<string[]> GetFileListAsync(FileExtension fileExtension, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists the files whose names match the specified pattern (asynchronous).
		/// When the pattern has a known extension (e.g. "*.JBI"), only the matching folder is listed.
		/// Otherwise, all folders of the controller are listed.
		/// </summary>
		/// <param name="pattern">File name pattern, with '*' and '?' wildcards (e.g. "*.JBI", "VISION*.JBI", "/DAT/*.DAT").</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Array of matching file names (e.g. "TEST.JBI").</returns>
		public Task<string[]> GetFileListByPatternAsync(string pattern, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads text content to the robot controller as a file.
		/// The file type is given by the extension of <code class="paramref">fileName</code> (e.g. ".JBI" for a job).
		/// </summary>
		/// <param name="fileName">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="content">The text content to write. Must not be empty.</param>
		public void LoadFile(string fileName, string content)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a file from the robot controller.
		/// The "anonymous" user cannot delete files.
		/// </summary>
		/// <param name="fileName">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		public void DeleteFile(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads text content to the robot controller as a file (asynchronous).
		/// The file type is given by the extension of <code class="paramref">fileName</code> (e.g. ".JBI" for a job).
		/// </summary>
		/// <param name="fileName">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="content">The text content to write. Must not be empty.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task LoadFileAsync(string fileName, string content, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a file from the robot controller (asynchronous).
		/// The "anonymous" user cannot delete files.
		/// </summary>
		/// <param name="fileName">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task DeleteFileAsync(string fileName, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a byte array as a file onto the controller.
		/// Only jobs (.JBI, .JBR), condition files (.CND) and general data (.DAT) can be uploaded, with the "ftp" or "rcmaster" user.
		/// An existing job is not overwritten: delete it first with <see cref="UnderAutomation.Yaskawa.Ftp.Internal.FtpClientBase.DeleteFile(System.String)"/>.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="data">Full content of the file. Must not be empty.</param>
		/// <param name="progress">Reports upload progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		public void UploadFile(string remotePath, byte[] data, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads the content of a stream as a file onto the controller. The stream is read from its current position to its end.
		/// Only jobs (.JBI, .JBR), condition files (.CND) and general data (.DAT) can be uploaded, with the "ftp" or "rcmaster" user.
		/// An existing job is not overwritten: delete it first with <see cref="UnderAutomation.Yaskawa.Ftp.Internal.FtpClientBase.DeleteFile(System.String)"/>.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="source">Stream that contains the file content. Must not be empty.</param>
		/// <param name="progress">Reports upload progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		public void UploadFileFromStream(string remotePath, Stream source, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads a local file onto the controller.
		/// Only jobs (.JBI, .JBR), condition files (.CND) and general data (.DAT) can be uploaded, with the "ftp" or "rcmaster" user.
		/// An existing job is not overwritten: delete it first with <see cref="UnderAutomation.Yaskawa.Ftp.Internal.FtpClientBase.DeleteFile(System.String)"/>.
		/// </summary>
		/// <param name="localPath">Path to the file on the local file system.</param>
		/// <param name="remotePath">Name or full path of the file on the controller. If null or empty, the local file name is used.</param>
		/// <param name="progress">Reports upload progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		public void UploadFileFromLocal(string localPath, string remotePath = null, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads several local files onto the controller. Each file is uploaded with its local file name.
		/// The controller stores each file in the folder of its type (e.g. a ".JBI" file goes to the JOB folder).
		/// The upload stops at the first error.
		/// </summary>
		/// <param name="localPaths">Paths to the files on the local file system.</param>
		/// <param name="progress">Reports global progress as a percentage (0 to 100).</param>
		/// <returns>Names of the uploaded files on the controller.</returns>
		public string[] UploadFilesFromLocal(string[] localPaths, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a byte array as a file onto the controller (asynchronous).
		/// Only jobs (.JBI, .JBR), condition files (.CND) and general data (.DAT) can be uploaded, with the "ftp" or "rcmaster" user.
		/// An existing job is not overwritten: delete it first with <see cref="UnderAutomation.Yaskawa.Ftp.Internal.FtpClientBase.DeleteFileAsync(System.String,System.Threading.CancellationToken)"/>.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="data">Full content of the file. Must not be empty.</param>
		/// <param name="progress">Reports upload progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task UploadFileAsync(string remotePath, byte[] data, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads the content of a stream as a file onto the controller (asynchronous). The stream is read from its current position to its end.
		/// Only jobs (.JBI, .JBR), condition files (.CND) and general data (.DAT) can be uploaded, with the "ftp" or "rcmaster" user.
		/// An existing job is not overwritten: delete it first with <see cref="UnderAutomation.Yaskawa.Ftp.Internal.FtpClientBase.DeleteFileAsync(System.String,System.Threading.CancellationToken)"/>.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI").</param>
		/// <param name="source">Stream that contains the file content. Must not be empty.</param>
		/// <param name="progress">Reports upload progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task UploadFileFromStreamAsync(string remotePath, Stream source, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a local file onto the controller (asynchronous).
		/// Only jobs (.JBI, .JBR), condition files (.CND) and general data (.DAT) can be uploaded, with the "ftp" or "rcmaster" user.
		/// An existing job is not overwritten: delete it first with <see cref="UnderAutomation.Yaskawa.Ftp.Internal.FtpClientBase.DeleteFileAsync(System.String,System.Threading.CancellationToken)"/>.
		/// </summary>
		/// <param name="localPath">Path to the file on the local file system.</param>
		/// <param name="remotePath">Name or full path of the file on the controller. If null or empty, the local file name is used.</param>
		/// <param name="progress">Reports upload progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task UploadFileFromLocalAsync(string localPath, string remotePath = null, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads several local files onto the controller (asynchronous). Each file is uploaded with its local file name.
		/// The controller stores each file in the folder of its type (e.g. a ".JBI" file goes to the JOB folder).
		/// The upload stops at the first error.
		/// </summary>
		/// <param name="localPaths">Paths to the files on the local file system.</param>
		/// <param name="progress">Reports global progress as a percentage (0 to 100).</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Names of the uploaded files on the controller.</returns>
		public Task<string[]> UploadFilesFromLocalAsync(string[] localPaths, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file from the controller and returns its content.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="progress">Reports download progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <returns>The content of the file.</returns>
		public byte[] DownloadFile(string remotePath, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file from the controller and writes its content into a stream.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="destination">Stream to write the file content into.</param>
		/// <param name="progress">Reports download progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		public void DownloadFileToStream(string remotePath, Stream destination, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Downloads a file from the controller and saves it on the local file system.
		/// Overwrites the local file if it already exists. The local file is not created if the download fails.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="localPath">Path where the file is saved on the local file system.</param>
		/// <param name="progress">Reports download progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		public void DownloadFileToLocal(string remotePath, string localPath, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Downloads several files from the controller into a local folder.
		/// Each file is saved with its name, and existing local files are overwritten.
		/// </summary>
		/// <param name="remotePaths">Names or full paths of the files on the controller.</param>
		/// <param name="localFolder">Local folder where the files are saved. Created if it does not exist.</param>
		/// <param name="progress">Reports global progress as a percentage (0 to 100).</param>
		/// <returns>Local paths of the downloaded files.</returns>
		public string[] DownloadFilesToLocal(string[] remotePaths, string localFolder, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file from the controller and returns its content (asynchronous).
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="progress">Reports download progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>The content of the file.</returns>
		public Task<byte[]> DownloadFileAsync(string remotePath, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file from the controller and writes its content into a stream (asynchronous).
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="destination">Stream to write the file content into.</param>
		/// <param name="progress">Reports download progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task DownloadFileToStreamAsync(string remotePath, Stream destination, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file from the controller and saves it on the local file system (asynchronous).
		/// Overwrites the local file if it already exists. The local file is not created if the download fails.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="localPath">Path where the file is saved on the local file system.</param>
		/// <param name="progress">Reports download progress as a percentage (0 to 100). -1 indicates indeterminate progress.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task DownloadFileToLocalAsync(string remotePath, string localPath, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads several files from the controller into a local folder (asynchronous).
		/// Each file is saved with its name, and existing local files are overwritten.
		/// </summary>
		/// <param name="remotePaths">Names or full paths of the files on the controller.</param>
		/// <param name="localFolder">Local folder where the files are saved. Created if it does not exist.</param>
		/// <param name="progress">Reports global progress as a percentage (0 to 100).</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Local paths of the downloaded files.</returns>
		public Task<string[]> DownloadFilesToLocalAsync(string[] remotePaths, string localFolder, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks whether a file exists on the controller.
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <returns><code>true</code> if the file exists.</returns>
		public bool FileExists(string remotePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks whether a folder exists on the controller.
		/// </summary>
		/// <param name="path">Full path of the folder (e.g. "/JOB").</param>
		/// <returns><code>true</code> if the folder exists.</returns>
		public bool DirectoryExists(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks whether a file exists on the controller (asynchronous).
		/// </summary>
		/// <param name="remotePath">Name or full path of the file on the controller (e.g. "TEST.JBI" or "/JOB/TEST.JBI").</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns><code>true</code> if the file exists.</returns>
		public Task<bool> FileExistsAsync(string remotePath, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks whether a folder exists on the controller (asynchronous).
		/// </summary>
		/// <param name="path">Full path of the folder (e.g. "/JOB").</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns><code>true</code> if the folder exists.</returns>
		public Task<bool> DirectoryExistsAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the files and folders at the specified path on the controller.
		/// The root contains one folder per file type (JOB, DAT, CND, SYS, PRM, LST, CSV, LOG, TXT).
		/// </summary>
		/// <param name="path">Full path of the folder to list (e.g. "/JOB"). Use "/" or an empty string for the root.</param>
		/// <returns>Array of <see cref="UnderAutomation.Yaskawa.Ftp.FtpListItem"/> objects describing each entry.</returns>
		public FtpListItem[] GetListing(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the files and folders at the specified path on the controller (asynchronous).
		/// The root contains one folder per file type (JOB, DAT, CND, SYS, PRM, LST, CSV, LOG, TXT).
		/// </summary>
		/// <param name="path">Full path of the folder to list (e.g. "/JOB"). Use "/" or an empty string for the root.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Array of <see cref="UnderAutomation.Yaskawa.Ftp.FtpListItem"/> objects describing each entry.</returns>
		public Task<FtpListItem[]> GetListingAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected FtpClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the address of the robot controller: an IP address or a host name.
		/// </summary>
		public string Address { get; }

		/// <summary>
		/// Gets a value indicating whether the client is connected to a robot controller.
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// FTP user name used for the current connection.
		/// </summary>
		public string User { get; }
	}
}
