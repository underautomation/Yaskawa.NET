//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains torque values for each robot axis.
	/// Retrieved using the RTRQ (current torque) or RMAXTRQ (maximum torque) commands.
	/// </summary>
	public class HostControlTorqueData : HostControlResponse {

		/// <summary>
		/// Gets the torque values for each axis (up to 12 axes).
		/// Values are in percentage of maximum rated torque.
		/// </summary>
		public double[] Values { get; }
	}
}
