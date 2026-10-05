//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents a joint position of a 6-axis arm in degrees, with the same signs as the pendant.
	/// </summary>
	public interface IJointAngles {

		/// <summary>
		/// Angles of axes S, L, U, R, B, T in degrees.
		/// </summary>
		double[] Values { get; }
	}
}
