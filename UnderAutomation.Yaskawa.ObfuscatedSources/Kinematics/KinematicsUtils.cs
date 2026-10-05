//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.Kinematics {
	/// <summary>
	/// Forward and inverse kinematics of 6-axis Yaskawa arms.
	/// </summary>
	public static class KinematicsUtils {

		/// <summary>
		/// Computes the flange position for the given joint angles.
		/// </summary>
		/// <param name="joints">Joint angles in degrees (S, L, U, R, B, T), pendant signs.</param>
		/// <param name="parameters">DH parameters of the robot.</param>
		/// <returns>Flange position in the robot frame.</returns>
		public static CartesianPosition ForwardKinematics(IJointAngles joints, IDhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Computes all the joint solutions that put the flange at the given position.
		/// Joint limits are not checked. Angles are returned in the range (-180, 180].
		/// </summary>
		/// <param name="position">Flange position in the robot frame, for example a position read from the robot.</param>
		/// <param name="parameters">DH parameters of the robot.</param>
		/// <returns>All solutions found. Empty if the position cannot be reached.</returns>
		public static JointsAngles[] InverseKinematics(ICartesianPosition position, IDhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
