//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents a robot control group combining a group type with an index.
	/// Used to specify which robot or station to query in multi-robot systems.
	/// </summary>
	public class RobotControlGroup {

		/// <summary>
		/// Default control group for Cartesian position of robot 1.
		/// </summary>
		public static readonly RobotControlGroup DefaultRobotCartesian;

		/// <summary>
		/// Default control group for pulse position of robot 1.
		/// </summary>
		public static readonly RobotControlGroup DefaultRobotPulse;

		/// <summary>
		/// The control group type (robot, base, station).
		/// </summary>
		public readonly ControlGroup Group;

		/// <summary>
		/// The index within the control group (e.g., robot number 1-8).
		/// </summary>
		public readonly int Index;

		/// <summary>
		/// The combined byte value sent to the robot controller (Group + Index).
		/// </summary>
		public readonly byte ByteValue;

		/// <summary>
		/// Creates a new RobotControlGroup with the specified group type and index.
		/// </summary>
		/// <param name="group">The control group type.</param>
		/// <param name="index">The index within the group (1-based).</param>
		public RobotControlGroup(ControlGroup group, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
