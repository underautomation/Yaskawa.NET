//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Kinematics;

namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Denavit-Hartenberg parameters of a 6-axis Yaskawa arm (axes S, L, U, R, B, T).
	/// </summary>
	public class DhParameters : IDhParameters {

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.DhParameters"/> with zero lengths and standard home angles
		/// (<see cref="UnderAutomation.Yaskawa.Common.DhParameters.Theta2"/> = -90, <see cref="UnderAutomation.Yaskawa.Common.DhParameters.Theta3"/> = 0, <see cref="UnderAutomation.Yaskawa.Common.DhParameters.Theta5"/> = 0).
		/// </summary>
		public DhParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.DhParameters"/> with the specified values.
		/// </summary>
		/// <param name="a1">Offset between the S axis and the L axis (mm).</param>
		/// <param name="a2">Lower arm length (mm).</param>
		/// <param name="a3">Elbow offset (mm).</param>
		/// <param name="d4">Forearm length (mm).</param>
		/// <param name="d5">Wrist offset along the B axis (mm).</param>
		/// <param name="d6">Distance between the wrist and the flange (mm).</param>
		/// <param name="theta2">DH angle of the L axis at zero pulse (degrees).</param>
		/// <param name="theta3">DH angle of the U axis at zero pulse (degrees).</param>
		/// <param name="theta5">DH angle of the B axis at zero pulse (degrees).</param>
		public DhParameters(double a1, double a2, double a3, double d4, double d5, double d6, double theta2, double theta3, double theta5)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <see cref="UnderAutomation.Yaskawa.Common.DhParameters"/> by copying an existing <see cref="UnderAutomation.Yaskawa.Common.IDhParameters"/>.
		/// </summary>
		/// <param name="parameters">The source parameters to copy.</param>
		public DhParameters(IDhParameters parameters)
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
		/// Returns the DH parameters of a known robot model, from its name (for example "GP7" or "HC10DTP").
		/// The comparison ignores case.
		/// </summary>
		/// <param name="modelName">Robot model name, as given by the description of <see cref="UnderAutomation.Yaskawa.Kinematics.ArmKinematicModels"/> members.</param>
		/// <returns>The DH parameters, or null if the model is not known.</returns>
		public static DhParameters FromArmKinematicModelName(string modelName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the DH parameters of a known robot model.
		/// </summary>
		/// <param name="model">Robot model.</param>
		/// <returns>The DH parameters of this model.</returns>
		public static DhParameters FromArmKinematicModel(ArmKinematicModels model)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the DH parameters of robot group 1 from an ALL.PRM parameter file saved from a controller.
		/// DX100, DX200, FS100, YRC1000 and YRC1000micro files are supported.
		/// </summary>
		/// <param name="path">Path of the .prm file.</param>
		/// <returns>The DH parameters of the robot.</returns>
		public static DhParameters FromPrmFile(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the DH parameters of robot group 1 from the text content of an ALL.PRM parameter file.
		/// DX100, DX200, FS100, YRC1000 and YRC1000micro files are supported.
		/// </summary>
		/// <param name="content">Text content of the .prm file.</param>
		/// <returns>The DH parameters of the robot.</returns>
		public static DhParameters FromPrmContent(string content)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Offset between the S axis and the L axis, along the arm (mm).
		/// </summary>
		public double A1 { get; set; }

		/// <summary>
		/// Lower arm length, between the L axis and the U axis (mm).
		/// </summary>
		public double A2 { get; set; }

		/// <summary>
		/// Elbow offset, between the U axis and the forearm axis (mm).
		/// </summary>
		public double A3 { get; set; }

		/// <summary>
		/// Forearm length, between the U axis and the wrist (mm).
		/// </summary>
		public double D4 { get; set; }

		/// <summary>
		/// Wrist offset along the B axis (mm). Zero for a spherical wrist.
		/// </summary>
		public double D5 { get; set; }

		/// <summary>
		/// Distance between the wrist and the flange, along the T axis (mm).
		/// </summary>
		public double D6 { get; set; }

		/// <summary>
		/// DH angle of the L axis when the L axis is at zero pulse (degrees).
		/// </summary>
		public double Theta2 { get; set; }

		/// <summary>
		/// DH angle of the U axis when the U axis is at zero pulse (degrees).
		/// </summary>
		public double Theta3 { get; set; }

		/// <summary>
		/// DH angle of the B axis when the B axis is at zero pulse (degrees).
		/// </summary>
		public double Theta5 { get; set; }

		/// <summary>
		/// Kinematic structure of the arm: <see cref="UnderAutomation.Yaskawa.Common.KinematicsCategory.Opw"/> when <see cref="UnderAutomation.Yaskawa.Common.DhParameters.D5"/> is 0,
		/// <see cref="UnderAutomation.Yaskawa.Common.KinematicsCategory.J5OffsetWrist"/> otherwise.
		/// </summary>
		public KinematicsCategory KinematicsCategory { get; }
	}
}
