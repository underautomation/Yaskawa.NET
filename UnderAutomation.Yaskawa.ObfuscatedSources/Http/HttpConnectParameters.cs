//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Http {
	/// <summary>
	/// Connection parameters for HTTP communication with the robot controller.
	/// </summary>
	public class HttpConnectParameters {

		/// <summary>
		/// Default HTTP port (80).
		/// </summary>
		public const int DEFAULT_PORT = 80;

		/// <summary>
		/// Default timeout in milliseconds for HTTP requests (5000ms).
		/// </summary>
		public const int DEFAULT_TIMEOUT_MILLISECONDS = 5000;

		/// <summary>
		/// Initializes a new instance of the HTTP connection parameters.
		/// </summary>
		public HttpConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the HTTP port number.
		/// Default: 80.
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for a response.
		/// Default: 5000ms.
		/// </summary>
		public int TimeoutMilliseconds { get; set; }
	}
}
