//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the arm configuration (upper/lower) based on L and U axis positions.
	/// </summary>
	public enum ArmFlipInformation {

		/// <summary>
		/// Upper arm configuration - elbow is above the line between shoulder and wrist.
		/// </summary>
		Upper = 0,

		/// <summary>
		/// Lower arm configuration - elbow is below the line between shoulder and wrist.
		/// </summary>
		Lower = 1,
	}
}
