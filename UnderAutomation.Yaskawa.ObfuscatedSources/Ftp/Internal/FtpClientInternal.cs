//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.Ftp.Internal {
	/// <summary>
	/// Internal implementation of the FTP client.
	/// This class is not intended for direct use by application code.
	/// Use <see cref="UnderAutomation.Yaskawa.YaskawaRobot"/> instead.
	/// </summary>
	public class FtpClientInternal : FtpClientBase, IFileManager, IFileReader, IFileWriter, IYaskawaClient {
	}
}
