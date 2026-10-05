//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Http.Internal {
	/// <summary>
	/// Connection parameters for HTTP communication with the robot controller, with enable flag.
	/// </summary>
	public class HttpConnectParametersInternal : HttpConnectParameters {


		public HttpConnectParametersInternal()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets a value indicating whether to enable the HTTP connection (default: false).
		/// </summary>
		public bool Enable { get; set; }
	}
}
