//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Cartesian position of the robot flange in the robot frame.
	/// </summary>
	public class CartesianPosition : ICartesianPosition {

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.CartesianPosition"/> at the origin, with zero angles.
		/// </summary>
		public CartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.CartesianPosition"/> with the specified values.
		/// </summary>
		/// <param name="x">X position (mm).</param>
		/// <param name="y">Y position (mm).</param>
		/// <param name="z">Z position (mm).</param>
		/// <param name="rx">Rotation around the X axis (degrees).</param>
		/// <param name="ry">Rotation around the Y axis (degrees).</param>
		/// <param name="rz">Rotation around the Z axis (degrees).</param>
		public CartesianPosition(double x, double y, double z, double rx, double ry, double rz)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.CartesianPosition"/> by copying any Cartesian position,
		/// for example a position read from the robot.
		/// </summary>
		/// <param name="position">The position to copy.</param>
		public CartesianPosition(ICartesianPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns the 4x4 homogeneous matrix of this position (rotation and translation in mm).
		/// </summary>
		/// <returns>A 4x4 matrix.</returns>
		public double[,] ToHomogeneousMatrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a Cartesian position from a homogeneous matrix (3x4 or 4x4, translation in mm).
		/// When Ry is +90 or -90 degrees, Rx and Rz are not unique: Rz is set to 0.
		/// </summary>
		/// <param name="matrix">Homogeneous matrix.</param>
		/// <returns>The Cartesian position.</returns>
		public static CartesianPosition FromHomogeneousMatrix(double[,] matrix)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// X position in millimeters.
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y position in millimeters.
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z position in millimeters.
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// Rotation around the X axis in degrees.
		/// </summary>
		public double Rx { get; set; }

		/// <summary>
		/// Rotation around the Y axis in degrees.
		/// </summary>
		public double Ry { get; set; }

		/// <summary>
		/// Rotation around the Z axis in degrees.
		/// </summary>
		public double Rz { get; set; }
	}
}
