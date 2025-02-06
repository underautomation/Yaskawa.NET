//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {

	public class RobotStatusData : RobotData {


		public bool Step { get; set; }


		public bool Cycle { get; set; }


		public bool Automatic { get; set; }


		public bool Running { get; set; }


		public bool InGuardSafeOperation { get; set; }


		public bool Teach { get; set; }


		public bool Play { get; set; }


		public bool CommandRemote { get; set; }


		public bool InHoldStatusPendant { get; set; }


		public bool InHoldStatusExternally { get; set; }


		public bool InHoldStatusByCommand { get; set; }


		public bool Alarming { get; set; }


		public bool ErrorOccurring { get; set; }


		public bool ServoOn { get; set; }
	}
}
