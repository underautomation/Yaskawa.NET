//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies whether an axis angle is less than or greater than/equal to 180 degrees.
	/// Used for determining robot configuration in multi-solution situations.
	/// </summary>
	public enum AxisFlipInformation {

		/// <summary>
		/// Axis angle is less than 180 degrees.
		/// </summary>
		LT180 = 0,

		/// <summary>
		/// Axis angle is greater than or equal to 180 degrees.
		/// </summary>
		UT180 = 1,
	}
}
