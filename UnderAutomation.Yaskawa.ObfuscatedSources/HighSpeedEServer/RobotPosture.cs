//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Represents the complete robot posture (form) configuration.
	/// Encodes the kinematic configuration choices that determine which of multiple
	/// inverse kinematics solutions is used to reach a Cartesian position.
	/// </summary>
	public class RobotPosture {

		/// <summary>
		/// Default posture with Form=0 and ExtendedForm=0.
		/// </summary>
		public static readonly RobotPosture Default;

		/// <summary>
		/// Creates a new RobotPosture with default values.
		/// </summary>
		public RobotPosture()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new RobotPosture with specified form values.
		/// </summary>
		/// <param name="form">Primary form byte value.</param>
		/// <param name="extendedForm">Extended form byte value.</param>
		public RobotPosture(int form, int extendedForm)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new RobotPosture with specified configuration values.
		/// </summary>
		/// <param name="orientation">Front/back orientation configuration.</param>
		/// <param name="arm">Upper/lower arm configuration.</param>
		/// <param name="flip">Flip/no-flip wrist configuration.</param>
		/// <param name="rAxis">R-axis angle range configuration.</param>
		/// <param name="tAxis">T-axis angle range configuration.</param>
		/// <param name="sAxis">S-axis angle range configuration.</param>
		/// <param name="redundant">Redundant axis orientation configuration.</param>
		/// <param name="regardedReversePositionSpecified">Reverse position specification mode.</param>
		/// <param name="lAxis">L-axis angle range configuration.</param>
		/// <param name="uAxis">U-axis angle range configuration.</param>
		/// <param name="bAxis">B-axis angle range configuration.</param>
		/// <param name="eAxis">E-axis angle range configuration.</param>
		/// <param name="wAxis">W-axis angle range configuration.</param>
		public RobotPosture(OrientationFlipInformation orientation = OrientationFlipInformation.Front, ArmFlipInformation arm = ArmFlipInformation.Upper, FlipNoFlipInformation flip = FlipNoFlipInformation.Flip, AxisFlipInformation rAxis = AxisFlipInformation.LT180, AxisFlipInformation tAxis = AxisFlipInformation.LT180, AxisFlipInformation sAxis = AxisFlipInformation.LT180, OrientationFlipInformation redundant = OrientationFlipInformation.Front, RegardedReversePositionSpecified regardedReversePositionSpecified = RegardedReversePositionSpecified.Previous, AxisFlipInformation lAxis = AxisFlipInformation.LT180, AxisFlipInformation uAxis = AxisFlipInformation.LT180, AxisFlipInformation bAxis = AxisFlipInformation.LT180, AxisFlipInformation eAxis = AxisFlipInformation.LT180, AxisFlipInformation wAxis = AxisFlipInformation.LT180)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Converts the posture to a single 16-bit integer value.
		/// Form is stored in the low byte, ExtendedForm in the high byte.
		/// </summary>
		/// <returns>Combined integer representation of the posture.</returns>
		public int ToInteger()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a RobotPosture from a combined 16-bit integer value.
		/// </summary>
		/// <param name="value">Combined integer with Form in low byte and ExtendedForm in high byte.</param>
		/// <returns>A new RobotPosture instance.</returns>
		public static RobotPosture FromInteger(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets or sets the primary form byte encoding basic posture flags.
		/// Bit-encoded: orientation, arm, flip, R-axis, T-axis, S-axis, redundant, reverse position.
		/// </summary>
		public int Form { get; set; }

		/// <summary>
		/// Gets or sets the extended form byte for additional axis configurations.
		/// Bit-encoded: L-axis, U-axis, B-axis, E-axis, W-axis range flags.
		/// </summary>
		public int ExtendedForm { get; set; }

		/// <summary>
		/// Gets or sets the front/back orientation configuration.
		/// Specifies where the B-axis rotation center locates relative to the S-axis
		/// when viewing the L and U axes from the right-hand side.
		/// </summary>
		public OrientationFlipInformation Orientation { get; set; }

		/// <summary>
		/// Gets or sets the upper/lower arm configuration based on L and U axis positions.
		/// </summary>
		public ArmFlipInformation Arm { get; set; }

		/// <summary>
		/// Gets or sets the flip/no-flip wrist configuration.
		/// </summary>
		public FlipNoFlipInformation Flip { get; set; }

		/// <summary>
		/// Gets or sets the R-axis (wrist rotation) angle range configuration.
		/// </summary>
		public AxisFlipInformation RAxis { get; set; }

		/// <summary>
		/// Gets or sets the T-axis (tool rotation) angle range configuration.
		/// </summary>
		public AxisFlipInformation TAxis { get; set; }

		/// <summary>
		/// Gets or sets the S-axis (base rotation) angle range configuration.
		/// </summary>
		public AxisFlipInformation SAxis { get; set; }

		/// <summary>
		/// Gets or sets the redundant axis orientation configuration (for 7+ axis robots).
		/// </summary>
		public OrientationFlipInformation Redundant { get; set; }

		/// <summary>
		/// Gets or sets the reverse position specification mode.
		/// </summary>
		public RegardedReversePositionSpecified RegardedReversePositionSpecified { get; set; }

		/// <summary>
		/// Gets or sets the L-axis (lower arm) angle range configuration from extended form.
		/// </summary>
		public AxisFlipInformation LAxis { get; set; }

		/// <summary>
		/// Gets or sets the U-axis (upper arm) angle range configuration from extended form.
		/// </summary>
		public AxisFlipInformation UAxis { get; set; }

		/// <summary>
		/// Gets or sets the B-axis (wrist bend) angle range configuration from extended form.
		/// </summary>
		public AxisFlipInformation BAxis { get; set; }

		/// <summary>
		/// Gets or sets the E-axis (external/elbow) angle range configuration from extended form.
		/// </summary>
		public AxisFlipInformation EAxis { get; set; }

		/// <summary>
		/// Gets or sets the W-axis angle range configuration from extended form.
		/// </summary>
		public AxisFlipInformation WAxis { get; set; }
	}
}
