//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl.Internal {
	/// <summary>
	/// Base class defining connection parameters for the Host Control communication.
	/// This class cannot be instantiated directly; use <see cref="UnderAutomation.Yaskawa.HostControl.EServerConnectParameters"/> instead.
	/// </summary>
	public abstract class HostControlConnectParametersBase {

		/// <summary>
		/// Default timeout in milliseconds for commands (5000ms).
		/// </summary>
		public const int DEFAULT_TIMEOUT_MILLISECONDS = 5000;

		/// <summary>
		/// Default timeout in milliseconds for servo power on operations (10000ms).
		/// </summary>
		public const int DEFAULT_POWER_ON_TIMEOUT_MILLISECONDS = 10000;

		/// <summary>
		/// Default timeout in milliseconds for motion commands (30000ms).
		/// </summary>
		public const int DEFAULT_MOTION_TIMEOUT_MILLISECONDS = 30000;

		/// <summary>
		/// Initializes a new instance of the connection parameters base class.
		/// </summary>
		protected HostControlConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for a response to commands.
		/// Default: 5000ms.
		/// </summary>
		public int TimeoutMilliseconds { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for servo power on to complete.
		/// Servo power on may take longer due to brake release and motor initialization.
		/// Default: 10000ms.
		/// </summary>
		public int PowerOnTimeoutMilliseconds { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in milliseconds to wait for motion commands to complete.
		/// Motion commands may take longer depending on the distance to travel.
		/// Default: 30000ms.
		/// </summary>
		public int MotionTimeoutMilliseconds { get; set; }
	}
}
