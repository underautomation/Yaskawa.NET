//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the orientation (front/back) configuration of the robot arm.
	/// Determined by the position of the B-axis rotation center relative to the S-axis.
	/// </summary>
	public enum OrientationFlipInformation {

		/// <summary>
		/// Front configuration - B-axis rotation center is in front of S-axis rotation center
		/// when viewed from the right-hand side of the robot.
		/// </summary>
		Front = 0,

		/// <summary>
		/// Back configuration - B-axis rotation center is behind S-axis rotation center
		/// when viewed from the right-hand side of the robot.
		/// </summary>
		Back = 1,
	}
}
