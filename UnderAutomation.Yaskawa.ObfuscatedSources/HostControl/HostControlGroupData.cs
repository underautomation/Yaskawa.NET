//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains control group information.
	/// Retrieved using the RGROUP command.
	/// </summary>
	public class HostControlGroupData : HostControlResponse {

		/// <summary>
		/// Gets or sets the robot group bits.
		/// Each bit represents a robot control group (R1, R2, etc.).
		/// </summary>
		public int RobotGroup { get; }

		/// <summary>
		/// Gets or sets the station group bits.
		/// Each bit represents a station control group (S1, S2, etc.).
		/// </summary>
		public int StationGroup { get; }

		/// <summary>
		/// Gets or sets the current task number.
		/// 0: Master task, 1-15: Sub tasks.
		/// </summary>
		public int Task { get; }
	}
}
