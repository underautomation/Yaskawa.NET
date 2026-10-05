//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains user coordinate frame data defined by three reference points (ORG, XX, XY).
	/// Retrieved using the RUFRAME command, written using the WUFRAME command.
	/// </summary>
	public class HostControlUserFrameData : HostControlResponse {

		/// <summary>
		/// Gets or sets the user coordinate number (2-64).
		/// </summary>
		public int UserCoordinateNumber { get; }

		/// <summary>
		/// ORG X coordinate value in mm.
		/// </summary>
		public double OrgX { get; }

		/// <summary>
		/// ORG Y coordinate value in mm.
		/// </summary>
		public double OrgY { get; }

		/// <summary>
		/// ORG Z coordinate value in mm.
		/// </summary>
		public double OrgZ { get; }

		/// <summary>
		/// ORG wrist angle TX in degrees.
		/// </summary>
		public double OrgTx { get; }

		/// <summary>
		/// ORG wrist angle TY in degrees.
		/// </summary>
		public double OrgTy { get; }

		/// <summary>
		/// ORG wrist angle TZ in degrees.
		/// </summary>
		public double OrgTz { get; }

		/// <summary>
		/// ORG posture type.
		/// </summary>
		public int OrgType { get; }

		/// <summary>
		/// XX X coordinate value in mm.
		/// </summary>
		public double XxX { get; }

		/// <summary>
		/// XX Y coordinate value in mm.
		/// </summary>
		public double XxY { get; }

		/// <summary>
		/// XX Z coordinate value in mm.
		/// </summary>
		public double XxZ { get; }

		/// <summary>
		/// XX wrist angle TX in degrees.
		/// </summary>
		public double XxTx { get; }

		/// <summary>
		/// XX wrist angle TY in degrees.
		/// </summary>
		public double XxTy { get; }

		/// <summary>
		/// XX wrist angle TZ in degrees.
		/// </summary>
		public double XxTz { get; }

		/// <summary>
		/// XX posture type.
		/// </summary>
		public int XxType { get; }

		/// <summary>
		/// XY X coordinate value in mm.
		/// </summary>
		public double XyX { get; }

		/// <summary>
		/// XY Y coordinate value in mm.
		/// </summary>
		public double XyY { get; }

		/// <summary>
		/// XY Z coordinate value in mm.
		/// </summary>
		public double XyZ { get; }

		/// <summary>
		/// XY wrist angle TX in degrees.
		/// </summary>
		public double XyTx { get; }

		/// <summary>
		/// XY wrist angle TY in degrees.
		/// </summary>
		public double XyTy { get; }

		/// <summary>
		/// XY wrist angle TZ in degrees.
		/// </summary>
		public double XyTz { get; }

		/// <summary>
		/// XY posture type.
		/// </summary>
		public int XyType { get; }

		/// <summary>
		/// Tool number (0-63).
		/// </summary>
		public int ToolNumber { get; }

		/// <summary>
		/// 7th axis pulses (for travel axis, mm).
		/// </summary>
		public int Axis7 { get; }

		/// <summary>
		/// 8th axis pulses (for travel axis, mm).
		/// </summary>
		public int Axis8 { get; }

		/// <summary>
		/// 9th axis pulses (for travel axis, mm).
		/// </summary>
		public int Axis9 { get; }

		/// <summary>
		/// 10th axis pulses.
		/// </summary>
		public int Axis10 { get; }

		/// <summary>
		/// 11th axis pulses.
		/// </summary>
		public int Axis11 { get; }

		/// <summary>
		/// 12th axis pulses.
		/// </summary>
		public int Axis12 { get; }
	}
}
