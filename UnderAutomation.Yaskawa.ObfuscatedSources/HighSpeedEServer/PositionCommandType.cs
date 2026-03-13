//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the type of position command (motion instruction) to execute.
	/// Determines the path type and whether position is absolute or incremental.
	/// </summary>
	public enum PositionCommandType {

		/// <summary>
		/// Link (joint interpolated) motion to an absolute position.
		/// All joints move simultaneously to reach the target, resulting in non-linear TCP path.
		/// </summary>
		LinkAbsolute = 1,

		/// <summary>
		/// Straight (linear interpolated) motion to an absolute position.
		/// TCP moves in a straight line to the target position.
		/// </summary>
		StraightAbsolute = 2,

		/// <summary>
		/// Straight (linear interpolated) motion by an incremental offset.
		/// TCP moves in a straight line relative to current position.
		/// </summary>
		StraightIncrement = 3,
	}
}
