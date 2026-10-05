//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HighSpeedEServer {
	/// <summary>
	/// Specifies the type of management time data to retrieve.
	/// Different metrics track various aspects of robot operation.
	/// </summary>
	public enum ManagementTimeType {

		/// <summary>
		/// Total time the controller power has been on.
		/// </summary>
		ControlPowerOnTime = 1,

		/// <summary>
		/// Total servo power on time across all robots.
		/// </summary>
		ServoPowerOnTimeTotal = 10,

		/// <summary>
		/// Servo power on time for robots R1 through R8.
		/// Pass the robot number (1 to 8) as index of GetManagementTime.
		/// </summary>
		ServoPowerOnTimR1ToR8 = 10,

		/// <summary>
		/// Servo power on time for stations S1 through S24.
		/// Pass the station number (1 to 24) as index of GetManagementTime.
		/// </summary>
		ServoPowerOnTimeS1ToS24 = 20,

		/// <summary>
		/// Total playback time across all robots.
		/// </summary>
		PlayBackTimeTotal = 110,

		/// <summary>
		/// Playback time for robots R1 through R8.
		/// Pass the robot number (1 to 8) as index of GetManagementTime.
		/// </summary>
		PlayBackTimeR1ToR8 = 110,

		/// <summary>
		/// Playback time for stations S1 through S24.
		/// Pass the station number (1 to 24) as index of GetManagementTime.
		/// </summary>
		PlayBackTimeS1ToS24 = 120,

		/// <summary>
		/// Total motion time across all robots.
		/// </summary>
		MotionTimeTotal = 210,

		/// <summary>
		/// Motion time for robots R1 through R8.
		/// Pass the robot number (1 to 8) as index of GetManagementTime.
		/// </summary>
		MotionTimeR1ToR8 = 210,

		/// <summary>
		/// Motion time for stations S1 through S24.
		/// Pass the station number (1 to 24) as index of GetManagementTime.
		/// </summary>
		MotionTimeS1ToS24 = 220,

		/// <summary>
		/// Operation time for applications 1 through 8.
		/// Add application number (0-7) to get specific application.
		/// </summary>
		OperationTimeApplication1To8 = 300,
	}
}
