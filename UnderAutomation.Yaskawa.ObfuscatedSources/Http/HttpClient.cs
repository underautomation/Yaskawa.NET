//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Http.Internal;
using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.Http {
	/// <summary>
	/// Standalone client class for communicating with Yaskawa Motoman industrial robots via HTTP.
	/// Provides file listing and file content retrieval from the robot controller's built-in web server.
	/// </summary>
	public class HttpClient : HttpClientBase, IFileReader, IYaskawaClient {

		/// <summary>
		/// Creates a new instance of HttpClient for robot communication.
		/// Call Connect() to establish communication with a robot controller.
		/// </summary>
		public HttpClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot controller using default parameters.
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller.</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot controller with custom connection parameters.
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller.</param>
		/// <param name="parameters">HTTP connection parameters including port and timeouts.</param>
		public void Connect(string ip, HttpConnectParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
