//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.ComponentModel;
using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.Kinematics.Internal {
	/// <summary>
	/// Attribute that associates DH parameters with an arm kinematic model enum value.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class ArmModelAttribute : DescriptionAttribute, IDhParameters {

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Kinematics.Internal.ArmModelAttribute"/> with the specified description and DH parameters.
		/// </summary>
		/// <param name="description">The robot model name.</param>
		/// <param name="a1">Offset between the S axis and the L axis (mm).</param>
		/// <param name="a2">Lower arm length (mm).</param>
		/// <param name="a3">Elbow offset (mm).</param>
		/// <param name="d4">Forearm length (mm).</param>
		/// <param name="d5">Wrist offset along the B axis (mm).</param>
		/// <param name="d6">Distance between the wrist and the flange (mm).</param>
		/// <param name="theta2">DH angle of the L axis at zero pulse (degrees).</param>
		/// <param name="theta3">DH angle of the U axis at zero pulse (degrees).</param>
		/// <param name="theta5">DH angle of the B axis at zero pulse (degrees).</param>
		public ArmModelAttribute(string description, double a1, double a2, double a3, double d4, double d5, double d6, double theta2, double theta3, double theta5)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Offset between the S axis and the L axis, along the arm (mm).
		/// </summary>
		public double A1 { get; }

		/// <summary>
		/// Lower arm length, between the L axis and the U axis (mm).
		/// </summary>
		public double A2 { get; }

		/// <summary>
		/// Elbow offset, between the U axis and the forearm axis (mm).
		/// </summary>
		public double A3 { get; }

		/// <summary>
		/// Forearm length, between the U axis and the wrist (mm).
		/// </summary>
		public double D4 { get; }

		/// <summary>
		/// Wrist offset along the B axis (mm). Zero for a spherical wrist.
		/// </summary>
		public double D5 { get; }

		/// <summary>
		/// Distance between the wrist and the flange, along the T axis (mm).
		/// </summary>
		public double D6 { get; }

		/// <summary>
		/// DH angle of the L axis when the L axis is at zero pulse (degrees).
		/// </summary>
		public double Theta2 { get; }

		/// <summary>
		/// DH angle of the U axis when the U axis is at zero pulse (degrees).
		/// </summary>
		public double Theta3 { get; }

		/// <summary>
		/// DH angle of the B axis when the B axis is at zero pulse (degrees).
		/// </summary>
		public double Theta5 { get; }
	}
}
