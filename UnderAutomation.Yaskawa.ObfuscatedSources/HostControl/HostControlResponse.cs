//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Base class for all robot data response objects returned by Host Control commands.
	/// Contains common response information about the communication.
	/// </summary>
	public class HostControlResponse {

		/// <summary>
		/// Gets or sets the raw response code from the robot controller.
		/// "0000" indicates normal completion.
		/// </summary>
		public string ResponseCode { get; }

		/// <summary>
		/// Gets or sets the command that was executed.
		/// </summary>
		public string Command { get; }

		/// <summary>
		/// Gets a value indicating whether the command completed successfully.
		/// </summary>
		public bool Success { get; }

		/// <summary>
		/// Gets or sets the error message if the command failed.
		/// </summary>
		public string ErrorMessage { get; }
	}
}
