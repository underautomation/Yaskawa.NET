//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains extended information about a robot alarm, including sub-code details.
	/// Provides more detailed diagnostic information than the basic RobotAlarmData.
	/// </summary>
	public class RobotAlarmDataExtended : RobotAlarmData {

		/// <summary>
		/// Gets additional information about the alarm condition.
		/// Maximum 16 characters.
		/// </summary>
		public string AdditionnalInformation { get; }

		/// <summary>
		/// Gets the sub-code data providing detailed error context.
		/// Maximum 96 characters.
		/// </summary>
		public string SubData { get; }

		/// <summary>
		/// Gets the reversed sub-code data.
		/// Maximum 96 characters.
		/// </summary>
		public string SubDataReverse { get; }
	}
}
