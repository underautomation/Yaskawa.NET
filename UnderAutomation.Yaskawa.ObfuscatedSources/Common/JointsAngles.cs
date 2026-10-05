//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Joint angles of a 6-axis arm, in degrees, with the same signs as the pendant (axes S, L, U, R, B, T).
	/// </summary>
	public class JointsAngles : IJointAngles {

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.JointsAngles"/> with all angles at 0.
		/// </summary>
		public JointsAngles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.JointsAngles"/> with the specified angles (degrees).
		/// </summary>
		/// <param name="s">S axis angle.</param>
		/// <param name="l">L axis angle.</param>
		/// <param name="u">U axis angle.</param>
		/// <param name="r">R axis angle.</param>
		/// <param name="b">B axis angle.</param>
		/// <param name="t">T axis angle.</param>
		public JointsAngles(double s, double l, double u, double r, double b, double t)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.JointsAngles"/> from an array of at least 6 angles (degrees).
		/// The array is copied.
		/// </summary>
		/// <param name="values">Angles of axes S, L, U, R, B, T.</param>
		public JointsAngles(double[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Angles of axes S, L, U, R, B, T in degrees.
		/// </summary>
		public double[] Values { get; }

		/// <summary>
		/// S axis angle (degrees).
		/// </summary>
		public double S { get; set; }

		/// <summary>
		/// L axis angle (degrees).
		/// </summary>
		public double L { get; set; }

		/// <summary>
		/// U axis angle (degrees).
		/// </summary>
		public double U { get; set; }

		/// <summary>
		/// R axis angle (degrees).
		/// </summary>
		public double R { get; set; }

		/// <summary>
		/// B axis angle (degrees).
		/// </summary>
		public double B { get; set; }

		/// <summary>
		/// T axis angle (degrees).
		/// </summary>
		public double T { get; set; }
	}
}
