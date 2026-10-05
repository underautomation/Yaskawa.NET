//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains encoder temperature values for each robot axis.
	/// Retrieved using the RENCTMP command.
	/// </summary>
	public class HostControlEncoderTemperatureData : HostControlResponse {

		/// <summary>
		/// Gets the temperature values for each axis encoder (up to 12 axes).
		/// Values are in degrees Celsius.
		/// </summary>
		public double[] Values { get; }
	}
}
