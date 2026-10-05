//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Specifies the type of variable to read or write.
	/// </summary>
	public enum HostControlVariableType {

		/// <summary>
		/// Byte variable (B).
		/// </summary>
		Byte = 0,

		/// <summary>
		/// Integer variable (I).
		/// </summary>
		Integer = 1,

		/// <summary>
		/// Double integer variable (D).
		/// </summary>
		DoubleInteger = 2,

		/// <summary>
		/// Real (floating point) variable (R).
		/// </summary>
		Real = 3,

		/// <summary>
		/// Robot axis position variable (P).
		/// </summary>
		Position = 4,

		/// <summary>
		/// Base axis position variable (BP).
		/// </summary>
		BasePosition = 5,

		/// <summary>
		/// Station axis position variable (EX), pulse type only.
		/// </summary>
		ExternalPosition = 6,

		/// <summary>
		/// String variable (S).
		/// </summary>
		String = 7,
	}
}
