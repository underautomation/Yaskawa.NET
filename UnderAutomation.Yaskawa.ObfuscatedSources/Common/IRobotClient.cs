//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Super-interface that combines all robot control capabilities.
	/// Implemented by High Speed Ethernet Server and Host Control clients.
	/// </summary>
	public interface IRobotClient : IStatusReader, IPositionReader, IAlarmReader, IRobotControl, IIOAccess, IVariableAccess, ITorqueReader, IMotionControl, IYaskawaClient {
	}
}
