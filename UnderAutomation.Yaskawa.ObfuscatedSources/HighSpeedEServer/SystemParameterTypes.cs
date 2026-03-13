//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Specifies the category of a system parameter to read from the controller.
	/// Types S1CG, AP, and SE require a group number when reading.
	/// </summary>
	public enum SystemParameterTypes {

		/// <summary>
		/// S1CxG. requires group number.
		/// </summary>
		S1CG = 0,

		/// <summary>
		/// S2C
		/// </summary>
		S2C = 1,

		/// <summary>
		/// S3C
		/// </summary>
		S3C = 2,

		/// <summary>
		/// S4C
		/// </summary>
		S4C = 3,

		/// <summary>
		/// RS
		/// </summary>
		RS = 4,

		/// <summary>
		/// AxP. Requires a group number.
		/// </summary>
		AP = 5,

		/// <summary>
		/// SxE. Requires a group number.
		/// </summary>
		SE = 6,
	}
}
