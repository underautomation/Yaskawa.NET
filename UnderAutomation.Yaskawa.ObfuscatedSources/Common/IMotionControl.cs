//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides motion commands to move the robot.
	/// </summary>
	public interface IMotionControl : IYaskawaClient {

		/// <summary>
		/// Moves the robot to a Cartesian position.
		/// </summary>
		/// <param name="x">X position in mm.</param>
		/// <param name="y">Y position in mm.</param>
		/// <param name="z">Z position in mm.</param>
		/// <param name="rx">Rx rotation in degrees.</param>
		/// <param name="ry">Ry rotation in degrees.</param>
		/// <param name="rz">Rz rotation in degrees.</param>
		/// <param name="speed">Speed value (interpretation depends on protocol defaults).</param>
		/// <param name="tool">Tool number (0-63).</param>
		void MoveCartesian(double x, double y, double z, double rx, double ry, double rz, double speed, int tool = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the robot to a joint (pulse) position.
		/// </summary>
		/// <param name="axesPulse">Target axis positions in encoder pulses.</param>
		/// <param name="speed">Speed value (interpretation depends on protocol defaults).</param>
		/// <param name="tool">Tool number (0-63).</param>
		void MoveJoints(int[] axesPulse, double speed, int tool = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
