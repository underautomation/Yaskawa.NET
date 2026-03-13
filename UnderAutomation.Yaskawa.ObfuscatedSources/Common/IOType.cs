//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Yaskawa Motoman I/O signal type categories.
	/// </summary>
	public enum IOType {

		/// <summary>
		/// Robot user input signals (#00010–)
		/// </summary>
		GeneralInput = 0,

		/// <summary>
		/// Robot user output signals (#10010–)
		/// </summary>
		GeneralOutput = 1,

		/// <summary>
		/// External input signals (#20010–)
		/// </summary>
		ExternalInput = 2,

		/// <summary>
		/// Network input signals (#27010–)
		/// </summary>
		NetworkInput = 3,

		/// <summary>
		/// External output signals (#30010–)
		/// </summary>
		ExternalOutput = 4,

		/// <summary>
		/// Network output signals (#37010–)
		/// </summary>
		NetworkOutput = 5,

		/// <summary>
		/// Robot system input signals (#40010–)
		/// </summary>
		SpecificInput = 6,

		/// <summary>
		/// Robot system output signals (#50010–)
		/// </summary>
		SpecificOutput = 7,

		/// <summary>
		/// Interface panel input signals (#60010–)
		/// </summary>
		InterfacePanelInput = 8,

		/// <summary>
		/// Auxiliary relay signals (#70010–)
		/// </summary>
		AuxiliaryRelay = 9,

		/// <summary>
		/// Robot control status signals (#80010–)
		/// </summary>
		RobotControlStatus = 10,

		/// <summary>
		/// Pseudo input signals (#82010–)
		/// </summary>
		PseudoInput = 11,
	}
}
