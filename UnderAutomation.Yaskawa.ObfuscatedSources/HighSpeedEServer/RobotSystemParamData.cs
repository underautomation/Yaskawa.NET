//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains a system parameter value read from the robot controller.
	/// Retrieved using YERC command 0x039C.
	/// </summary>
	public class RobotSystemParamData : RobotData {

		/// <summary>
		/// Returns a string representation of the system parameter value.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the raw system parameter value returned by the controller.
		/// </summary>
		public uint Value { get; }
	}
}
