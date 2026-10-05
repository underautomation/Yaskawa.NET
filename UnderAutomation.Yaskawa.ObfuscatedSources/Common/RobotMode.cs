//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Specifies the robot operation mode.
	/// </summary>
	public enum RobotMode {

		/// <summary>
		/// Teach mode : robot can be manually positioned and jobs can be edited.
		/// </summary>
		Teach = 1,

		/// <summary>
		/// Play mode : robot can execute programmed jobs.
		/// </summary>
		Play = 2,
	}
}
