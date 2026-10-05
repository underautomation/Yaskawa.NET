//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains joint position data in pulse (encoder) values.
	/// </summary>
	public class HostControlJointPositionData : HostControlResponse, IJointPulses {

		/// <summary>
		/// Gets or sets the S axis position in pulses.
		/// </summary>
		public int S { get; }

		/// <summary>
		/// Gets or sets the L axis position in pulses.
		/// </summary>
		public int L { get; }

		/// <summary>
		/// Gets or sets the U axis position in pulses.
		/// </summary>
		public int U { get; }

		/// <summary>
		/// Gets or sets the R axis position in pulses.
		/// </summary>
		public int R { get; }

		/// <summary>
		/// Gets or sets the B axis position in pulses.
		/// </summary>
		public int B { get; }

		/// <summary>
		/// Gets or sets the T axis position in pulses.
		/// </summary>
		public int T { get; }

		/// <summary>
		/// Gets or sets the E axis (7th axis) position in pulses.
		/// </summary>
		public int E { get; }

		/// <summary>
		/// Gets or sets the 8th axis position in pulses.
		/// </summary>
		public int Axis8 { get; }

		/// <summary>
		/// Gets or sets the 9th axis position in pulses.
		/// </summary>
		public int Axis9 { get; }

		/// <summary>
		/// Gets or sets the 10th axis position in pulses.
		/// </summary>
		public int Axis10 { get; }

		/// <summary>
		/// Gets or sets the 11th axis position in pulses.
		/// </summary>
		public int Axis11 { get; }

		/// <summary>
		/// Gets or sets the 12th axis position in pulses.
		/// </summary>
		public int Axis12 { get; }

		/// <summary>
		/// Gets all axis values as an array of encoder pulse values.
		/// Array contains 12 elements: S, L, U, R, B, T, E, Axis8 through Axis12.
		/// </summary>
		public int[] Axes { get; }
	}
}
