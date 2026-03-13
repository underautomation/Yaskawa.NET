//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents a collection of data values returned from plural (batch) read operations.
	/// Used for reading multiple variables, registers, or I/O points in a single request.
	/// </summary>
	public class RobotPluralData<T> : RobotData {

		/// <summary>
		/// Gets the array of values read from the robot controller.
		/// The array length corresponds to the number of values successfully read.
		/// </summary>
		public T[] Value { get; }
	}
}
