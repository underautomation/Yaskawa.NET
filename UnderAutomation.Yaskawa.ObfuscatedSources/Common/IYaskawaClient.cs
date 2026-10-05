//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Base interface for all Yaskawa robot communication clients.
	/// Provides connection management shared across all communication protocols.
	/// </summary>
	public interface IYaskawaClient {

		/// <summary>
		/// Closes the connection to the robot controller and releases resources.
		/// </summary>
		void Close()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the address of the robot controller: an IP address or a host name.
		/// </summary>
		string Address { get; }

		/// <summary>
		/// Gets a value indicating whether the client is connected to a robot controller.
		/// </summary>
		bool Connected { get; }
	}
}
