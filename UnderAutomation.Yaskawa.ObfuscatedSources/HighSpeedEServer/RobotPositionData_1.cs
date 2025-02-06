//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {

	public class RobotPositionData<t> : RobotAxisRawData<t> {


		public RobotPositionData(RobotDataHeader header)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public RobotPosture Form { get; set; }


		public RobotPositionDataType DataType { get; set; }


		public int ToolNumber { get; set; }


		public int UserCoordinateNumber { get; set; }
	}
}
