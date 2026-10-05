//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.HostControl.Internal;
using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Standalone client class for communicating with Yaskawa Motoman industrial robots using the Host Control protocol via Ethernet Server (TCP).
	/// This class provides methods for reading robot status, positions, variables, and controlling robot operations.
	/// </summary>
	public class EServerClient : EServerClientInternal, IRobotClient, IStatusReader, IPositionReader, IAlarmReader, IRobotControl, IIOAccess, IVariableAccess, ITorqueReader, IMotionControl, IYaskawaClient {

		/// <summary>
		/// Creates a new instance of EServerClient for robot communication via TCP.
		/// Call Connect() to configure communication with a robot controller.
		/// </summary>
		public EServerClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Configures connection to the robot controller via TCP using default parameters.
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller.</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Configures connection to the robot controller via TCP.
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller.</param>
		/// <param name="parameters">Ethernet Server connection parameters including port and timeouts.</param>
		public void Connect(string ip, EServerConnectParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
