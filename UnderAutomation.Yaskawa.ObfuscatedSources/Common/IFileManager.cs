//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides complete file management: read, write, list, and delete operations.
	/// </summary>
	public interface IFileManager : IFileReader, IFileWriter, IYaskawaClient {
	}
}
