//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.HostControl.Internal {
	/// <summary>
	/// Internal implementation of the Host Control client for Ethernet Server (TCP) communication.
	/// Supports YRC1000 and compatible controllers.
	/// </summary>
	public class EServerClientInternal : HostControlClientBase, IRobotClient, IStatusReader, IPositionReader, IAlarmReader, IRobotControl, IIOAccess, IVariableAccess, ITorqueReader, IMotionControl, IYaskawaClient {

		/// <summary>
		/// Marks the client as disconnected and releases any stored state.
		/// </summary>
		public override void Close()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets a value indicating whether the client is ready to communicate with the robot.
		/// Since each command opens its own TCP connection, this reflects whether Connect has been called.
		/// </summary>
		public override bool Connected => default;

		/// <summary>
		/// Gets the address of the connected robot controller (IP address).
		/// </summary>
		public override string Address => default;

		/// <summary>
		/// Gets the TCP port number.
		/// </summary>
		public int Port { get; }
	}
}
