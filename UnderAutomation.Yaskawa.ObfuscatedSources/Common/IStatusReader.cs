//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides access to robot status and executing job information.
	/// </summary>
	public interface IStatusReader : IYaskawaClient {

		/// <summary>
		/// Reads the current operational status of the robot controller.
		/// </summary>
		/// <returns>Status data containing boolean flags for various robot states.</returns>
		IStatusData GetStatusInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the currently executing job information.
		/// </summary>
		/// <returns>Job data containing name, line number, and step.</returns>
		IJobData GetExecutingJobInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
