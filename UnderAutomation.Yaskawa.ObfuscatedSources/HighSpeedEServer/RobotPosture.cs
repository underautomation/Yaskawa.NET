//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {

	public class RobotPosture {


		public static readonly RobotPosture Default;


		public RobotPosture()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public int Form { get; set; }


		public int ExtendedForm { get; set; }


		public RobotPosture(int form, int extendedForm)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public OrientationFlipInformation Orientation { get; }


		public ArmFlipInformation Arm { get; }


		public FlipNoFlipInformation Flip { get; }


		public AxisFlipInformation RAxis { get; }


		public AxisFlipInformation TAxis { get; }


		public AxisFlipInformation SAxis { get; }


		public OrientationFlipInformation Redundant { get; }


		public RegardedReversePositionSpecified RegardedReversePositionSpecified { get; }


		public AxisFlipInformation LAxis { get; }


		public AxisFlipInformation UAxis { get; }


		public AxisFlipInformation BAxis { get; }


		public AxisFlipInformation EAxis { get; }


		public AxisFlipInformation WAxis { get; }


		public int ToInteger()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static RobotPosture FromInteger(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
