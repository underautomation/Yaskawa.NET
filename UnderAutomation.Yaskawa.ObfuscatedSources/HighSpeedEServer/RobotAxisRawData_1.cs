//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents raw axis data with generic value type for up to 8 axes.
	/// This is the base class for position-related data structures.
	/// </summary>
	public class RobotAxisRawData<T> : RobotData {

		/// <summary>
		/// Gets the array containing all axis values.
		/// Index 0-5 typically represent robot axes (S, L, U, R, B, T).
		/// Index 6-7 may be used for additional axes if available.
		/// </summary>
		public T[] Axes { get; }

		/// <summary>
		/// Gets or sets the value for axis 1 (typically S-axis / base rotation).
		/// </summary>
		public T Axis1 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 2 (typically L-axis / lower arm).
		/// </summary>
		public T Axis2 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 3 (typically U-axis / upper arm).
		/// </summary>
		public T Axis3 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 4 (typically R-axis / wrist rotation).
		/// </summary>
		public T Axis4 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 5 (typically B-axis / wrist bend).
		/// </summary>
		public T Axis5 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 6 (typically T-axis / tool rotation).
		/// </summary>
		public T Axis6 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 7 (optional additional axis).
		/// </summary>
		public T Axis7 { get; set; }

		/// <summary>
		/// Gets or sets the value for axis 8 (optional additional axis).
		/// </summary>
		public T Axis8 { get; set; }
	}
}
