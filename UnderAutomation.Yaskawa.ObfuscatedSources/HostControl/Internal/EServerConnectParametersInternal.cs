//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl.Internal {
	/// <summary>
	/// Connection parameters for Host Control Ethernet Server (TCP) communication.
	/// Use this class to configure network settings for TCP connection to YRC1000 and compatible controllers.
	/// </summary>
	public class EServerConnectParametersInternal : EServerConnectParameters {


		public EServerConnectParametersInternal()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets a value indicating whether to enable the Ethernet Server connection (default: false).
		/// </summary>
		public bool Enable { get; set; }
	}
}
