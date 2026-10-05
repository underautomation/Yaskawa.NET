//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides access to current robot position readings.
	/// </summary>
	public interface IPositionReader : IYaskawaClient {

		/// <summary>
		/// Reads the current robot joint position in pulse (encoder) values.
		/// </summary>
		/// <returns>Joint position data with axis values in encoder pulses.</returns>
		IJointPulses GetRobotJointPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current robot Cartesian position (TCP position and orientation).
		/// </summary>
		/// <returns>Cartesian position data with coordinates in mm and degrees.</returns>
		ICartesianPosition GetRobotCartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
