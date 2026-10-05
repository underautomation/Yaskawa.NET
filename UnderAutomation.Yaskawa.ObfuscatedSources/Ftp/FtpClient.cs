//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Ftp.Internal;
using System.Threading;
using System.Threading.Tasks;
using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.Ftp {
	/// <summary>
	/// Standalone FTP client for connecting directly to a Yaskawa robot controller.
	/// </summary>
	public class FtpClient : FtpClientBase, IFileManager, IFileReader, IFileWriter, IYaskawaClient {

		/// <summary>
		/// Creates a new standalone FTP client instance.
		/// </summary>
		public FtpClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot controller via FTP.
		/// </summary>
		/// <param name="ip">IP address or host name of the robot controller.</param>
		/// <param name="user">FTP user name. Defaults to <code>"anonymous"</code>.
		/// See <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.FtpUser"/> for a description of available accounts.</param>
		/// <param name="password">FTP password for <code class="paramref">user</code>. Defaults to <code>null</code> (accepted by <code>ftp</code> and <code>anonymous</code> accounts).</param>
		/// <param name="port">FTP port. Defaults to <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.DEFAULT_PORT"/> (21).</param>
		/// <param name="timeoutMilliseconds">Timeout in milliseconds for read, connect and data transfer operations.
		/// Defaults to <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.DEFAULT_TIMEOUT_MILLISECONDS"/> (30000ms).</param>
		public void Connect(string ip, string user = "anonymous", string password = null, int port = 21, int timeoutMilliseconds = 30000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot controller via FTP (asynchronous).
		/// </summary>
		/// <param name="ip">IP address or host name of the robot controller.</param>
		/// <param name="user">FTP user name. Defaults to <code>"anonymous"</code>.
		/// See <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.FtpUser"/> for a description of available accounts.</param>
		/// <param name="password">FTP password for <code class="paramref">user</code>. Defaults to <code>null</code> (accepted by <code>ftp</code> and <code>anonymous</code> accounts).</param>
		/// <param name="port">FTP port. Defaults to <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.DEFAULT_PORT"/> (21).</param>
		/// <param name="timeoutMilliseconds">Timeout in milliseconds for read, connect and data transfer operations.
		/// Defaults to <see cref="UnderAutomation.Yaskawa.Ftp.FtpConnectParameters.DEFAULT_TIMEOUT_MILLISECONDS"/> (30000ms).</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		public Task ConnectAsync(string ip, string user = "anonymous", string password = null, int port = 21, int timeoutMilliseconds = 30000, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
