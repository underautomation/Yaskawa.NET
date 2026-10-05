//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Kinematic structure of a 6-axis arm. It decides which inverse kinematics solver is used.
	/// </summary>
	public enum KinematicsCategory {

		/// <summary>
		/// Ortho-parallel base with a spherical wrist: the R, B and T axes meet at one point (D5 = 0).
		/// Most industrial arms (GP, MH, ES, HC20DT, HC30PL...). Up to 8 inverse kinematics solutions.
		/// </summary>
		Opw = 0,

		/// <summary>
		/// Ortho-parallel base with a wrist offset along the B axis (D5 is not 0): the R and T axes do not meet.
		/// Collaborative robots such as HC10, HC10DT, HC20SDT. Up to 16 inverse kinematics solutions.
		/// </summary>
		J5OffsetWrist = 1,
	}
}
