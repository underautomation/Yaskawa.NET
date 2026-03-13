//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the type of ON/OFF command to send to the robot controller.
	/// These commands control fundamental robot states that affect safety and operation.
	/// </summary>
	public enum OnOffCommandType : byte {

		/// <summary>
		/// Hold command - pauses robot motion while maintaining servo power.
		/// Robot can resume from held position. Value: 1.
		/// </summary>
		Hold = 1,

		/// <summary>
		/// Servo power command - enables or disables motor power to the robot.
		/// Servo must be ON for the robot to move. Value: 2.
		/// </summary>
		Servo = 2,

		/// <summary>
		/// Lock Teach Pendant. Value: 3.
		/// </summary>
		HLock = 3,
	}
}
