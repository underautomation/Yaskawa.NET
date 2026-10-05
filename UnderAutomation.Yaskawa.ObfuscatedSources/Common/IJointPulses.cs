//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents a robot joint position in pulse (encoder) values.
	/// </summary>
	public interface IJointPulses {

		/// <summary>
		/// Axis values in encoder pulses. Typically 8 to 12 elements depending on the robot configuration.
		/// </summary>
		int[] Axes { get; }
	}
}
