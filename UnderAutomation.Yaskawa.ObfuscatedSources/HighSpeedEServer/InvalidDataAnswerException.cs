//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace HighSpeedEServer {

	public class InvalidDataAnswerException : Exception, ISerializable {


		public int Status { get; set; }


		public int AddedStatus { get; set; }
	}
}
