//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Denavit-Hartenberg parameters of a 6-axis Yaskawa arm (axes S, L, U, R, B, T).
	/// </summary>
	public interface IDhParameters {

		/// <summary>
		/// Offset between the S axis and the L axis, along the arm (mm).
		/// </summary>
		double A1 { get; }

		/// <summary>
		/// Lower arm length, between the L axis and the U axis (mm).
		/// </summary>
		double A2 { get; }

		/// <summary>
		/// Elbow offset, between the U axis and the forearm axis (mm).
		/// </summary>
		double A3 { get; }

		/// <summary>
		/// Forearm length, between the U axis and the wrist (mm).
		/// </summary>
		double D4 { get; }

		/// <summary>
		/// Wrist offset along the B axis (mm). Zero for a spherical wrist.
		/// </summary>
		double D5 { get; }

		/// <summary>
		/// Distance between the wrist and the flange, along the T axis (mm).
		/// </summary>
		double D6 { get; }

		/// <summary>
		/// DH angle of the L axis when the L axis is at zero pulse (degrees).
		/// </summary>
		double Theta2 { get; }

		/// <summary>
		/// DH angle of the U axis when the U axis is at zero pulse (degrees).
		/// </summary>
		double Theta3 { get; }

		/// <summary>
		/// DH angle of the B axis when the B axis is at zero pulse (degrees).
		/// </summary>
		double Theta5 { get; }
	}
}
