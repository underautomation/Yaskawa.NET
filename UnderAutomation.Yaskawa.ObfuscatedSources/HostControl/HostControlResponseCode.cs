//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Specifies the interpreter error/response codes.
	/// </summary>
	public enum HostControlResponseCode {

		/// <summary>
		/// Normal completion.
		/// </summary>
		Success = 0,

		/// <summary>
		/// Manipulator is moving.
		/// </summary>
		ManipulatorMoving = 2010,

		/// <summary>
		/// In hold state (command).
		/// </summary>
		HoldByCommand = 2020,

		/// <summary>
		/// In hold state (external).
		/// </summary>
		HoldByExternal = 2030,

		/// <summary>
		/// In hold state (pendant).
		/// </summary>
		HoldByPendant = 2040,

		/// <summary>
		/// In hold state (operation panel).
		/// </summary>
		HoldByOperationPanel = 2050,

		/// <summary>
		/// Alarm or error occurring.
		/// </summary>
		AlarmOrError = 2060,

		/// <summary>
		/// Servo OFF.
		/// </summary>
		ServoOff = 2070,

		/// <summary>
		/// Incorrect mode.
		/// </summary>
		IncorrectMode = 2080,

		/// <summary>
		/// No command remote setting.
		/// </summary>
		NoCommandRemote = 2100,
	}
}
