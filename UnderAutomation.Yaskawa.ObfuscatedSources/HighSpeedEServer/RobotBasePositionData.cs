//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace HighSpeedEServer {

	public class RobotBasePositionData : RobotAxisRawData<int> {


		public RobotBasePositionData(RobotDataHeader header)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public RobotBasePositionType DataType { get; set; }
	}
}
