//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides access to robot axis torque readings.
	/// </summary>
	public interface ITorqueReader : IYaskawaClient {

		/// <summary>
		/// Reads the current torque values of all robot axes as a percentage of the maximum rated torque.
		/// </summary>
		/// <returns>Array of torque values as percentages (double). Array length depends on the protocol and robot configuration.</returns>
		double[] GetTorque()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
