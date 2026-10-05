//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents a robot Cartesian position (TCP position and orientation).
	/// </summary>
	public interface ICartesianPosition {

		/// <summary>
		/// X position in millimeters.
		/// </summary>
		double X { get; }

		/// <summary>
		/// Y position in millimeters.
		/// </summary>
		double Y { get; }

		/// <summary>
		/// Z position in millimeters.
		/// </summary>
		double Z { get; }

		/// <summary>
		/// Rotation around X axis in degrees.
		/// </summary>
		double Rx { get; }

		/// <summary>
		/// Rotation around Y axis in degrees.
		/// </summary>
		double Ry { get; }

		/// <summary>
		/// Rotation around Z axis in degrees.
		/// </summary>
		double Rz { get; }
	}
}
