//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using HighSpeedEServer;
using System;

namespace HighSpeedEServer.Internal {

	public abstract class HighSpeedEServerClientBase {


		public delegate void GetFileProgressDelegate(GetFileProgress progress);


		public delegate void LoadFileProgressDelegate(LoadFileProgress progress);


		protected HighSpeedEServerClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to a robot
		/// </summary>
		/// <param name="ip">IP or network name of the robot</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to a robot
		/// </summary>
		/// <param name="ip">IP or network name of the robot</param>
		/// <param name="parameters">Additional parameters</param>
		public void Connect(string ip, HighSpeedEServerConnectParametersBase parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Close the connection to the robot
		/// </summary>
		public void Close()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns information about active alarms
		/// </summary>
		/// <param name="alarm">Selected alarm you want to get information</param>
		public RobotAlarmData GetAlarm(RobotRecentAlarm alarm)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get robot status
		/// </summary>
		public RobotStatusData GetStatusInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get information about current running program
		/// </summary>
		public RobotJobData GetExecutingJobInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get default information about robot axes
		/// </summary>
		public RobotAxisRawData<string> GetConfigurationInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get information about robot axes
		/// </summary>
		/// <param name="type">Robot control group</param>
		public RobotAxisRawData<string> GetConfigurationInformation(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get current robot cartesian position
		/// </summary>
		public RobotPositionCartesianData GetRobotCartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get current robot joint position
		/// </summary>
		public RobotPositionData<int> GetRobotJointPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get position of a control group
		/// </summary>
		public RobotPositionData<int> GetRobotPosition(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get position error data
		/// </summary>
		public RobotPositionData<int> GetPositionError()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get position error data of a control group
		/// </summary>
		/// <param name="type">Control group</param>
		public RobotPositionData<int> GetPositionError(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get robot current torque
		/// </summary>
		public RobotPositionData<int> GetTorque()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get control group current torque
		/// </summary>
		/// <param name="type">Control group</param>
		public RobotPositionData<int> GetTorque(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Acknowledge alarms
		/// </summary>
		/// <param name="type">Alarm reset type</param>
		public RobotDataHeader AlarmReset(AlarmResetType type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Servo on / off the robot
		/// </summary>
		/// <param name="command">Command type</param>
		/// <param name="value">true for servo on, false for servo off</param>
		public RobotDataHeader ServoCommand(OnOffCommandType command, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Switch command
		/// </summary>
		/// <param name="command">Command type</param>
		public RobotDataHeader SwitchingCommand(SwitchingCommands command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Display a popup message on the pendant
		/// </summary>
		/// <param name="message">Message to display</param>
		public RobotDataHeader Display(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Start selected job
		/// </summary>
		public RobotDataHeader StartJob()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set selected job
		/// </summary>
		/// <param name="job">job name</param>
		/// <param name="line">job line</param>
		public RobotDataHeader SelectJob(string job, int line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get tasks executing time
		/// </summary>
		/// <param name="type">Management time type</param>
		/// <param name="index">optional index</param>
		public RobotManagementTimeData GetManagementTime(ManagementTimeType type, int index = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get information about the robot
		/// </summary>
		public RobotSystemInformation GetSystemInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get information about a robot system
		/// </summary>
		public RobotSystemInformation GetSystemInformation(RobotSystemTypeData type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read multiple inputs and outputs by index
		/// </summary>
		/// <param name="firstIndex">Index of first IO to read</param>
		/// <param name="count">number of bytes to read</param>
		public RobotPluralData<byte> ReadIO(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write IO
		/// </summary>
		/// <param name="data">Data array to write, should contains a pair number of element</param>
		public RobotDataHeader WriteIO(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read registers
		/// </summary>
		public RobotPluralData<ushort> ReadRegister(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write registers
		/// </summary>
		public RobotDataHeader WriteRegister(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read byte data from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<byte> ReadByte(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write byte data from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WriteByte(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read integer data from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<short> ReadInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write integer data from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WriteInteger(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read double data (64 bits) from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<double> ReadDouble(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write double data (float 64 bits) from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WriteDouble(int firstIndex, double[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read single data (float 32 bits) from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<float> ReadSingle(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write single data (float 32 bits) from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WriteSingle(int firstIndex, float[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read string data from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<string> Read16BytesChar(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write string data from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader Write16BytesChar(int firstIndex, string[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read position variables from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<RobotPositionData<int>> ReadPositionVariable(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write position variable from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WritePositionVariable(int firstIndex, RobotPositionData<int>[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read base position variable from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<RobotBasePositionData> ReadBasePosition(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write base position data from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WriteBasePosition(int firstIndex, RobotBasePositionData[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read external positions from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<RobotAxisRawData<int>> ReadExternalPosition(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write external position data from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader WriteExternalPosition(int firstIndex, RobotAxisRawData<int>[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get extended information about active alarms
		/// </summary>
		/// <param name="alarm">Index of alarm</param>
		public RobotAlarmDataExtended GetAlarmExtended(RobotRecentAlarm alarm)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Move robot to a cartesian position
		/// </summary>
		/// <param name="x">X coordinate in millimeter</param>
		/// <param name="y">Y coordinate in millimeter</param>
		/// <param name="z">Z coordinate in millimeter</param>
		/// <param name="rx">Rx  coordinate in degrees</param>
		/// <param name="ry">Ry  coordinate in degrees</param>
		/// <param name="rz">Rz  coordinate in degrees</param>
		/// <param name="classification">Unit for speed</param>
		/// <param name="speed">Move speed</param>
		/// <param name="coordinate">Frame coordinate</param>
		/// <param name="posture">Robot target posture (RCONF)</param>
		/// <param name="commandtype">Command type</param>
		/// <param name="RobotControlGroup">Control group</param>
		/// <param name="StationControlGroup">Station control group</param>
		/// <param name="tool">Selected TCP</param>
		/// <param name="userCoordinate">User coordinate for User coordinate</param>
		public RobotDataHeader MoveCartesian(double x, double y, double z, double rx, double ry, double rz, PositionCommandClassification classification, double speed, PositionCommandOperationCoordinate coordinate, RobotPosture posture = null, PositionCommandType commandtype = PositionCommandType.StraightIncrement, int RobotControlGroup = 1, int StationControlGroup = 0, int tool = 0, int userCoordinate = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Move robot to joint position
		/// </summary>
		/// <param name="axesPulse">Axes position in degrees</param>
		/// <param name="classification">Classification</param>
		/// <param name="speed">Movement speed in degrees/s</param>
		/// <param name="commandtype">Command type</param>
		/// <param name="RobotControlGroup">Robot control group</param>
		/// <param name="StationControlGroup">Station control group</param>
		/// <param name="tool">Selected TCP</param>
		public RobotDataHeader MoveJoints(int[] axesPulse, PositionCommandClassification classification, double speed, PositionCommandType commandtype = PositionCommandType.StraightIncrement, int RobotControlGroup = 1, int StationControlGroup = 1, int tool = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read string data from index
		/// </summary>
		/// <param name="firstIndex">Start index to read</param>
		/// <param name="count">number of index to read</param>
		public RobotPluralData<string> Read32BytesChar(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write string data from index. Array should contain a pair number of value
		/// </summary>
		/// <param name="firstIndex">First index to write data</param>
		/// <param name="data">Data to write, should contain a multiple of 2 elements</param>
		public RobotDataHeader Write32BytesChar(int firstIndex, string[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Delete a file by its name
		/// </summary>
		/// <param name="name">File name</param>
		public RobotDataHeader DeleteFile(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Download file to the robot
		/// </summary>
		/// <param name="name">File name on the robot</param>
		/// <param name="content">File content</param>
		public RobotDataHeader[] LoadFile(string name, string content, HighSpeedEServerClientBase.LoadFileProgressDelegate onLoadFileProgress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enumerate files
		/// </summary>
		/// <param name="pattern">File to enumerate, for example *.JBI to list every jobs</param>
		public RobotFileListData GetFileList(string pattern)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Upload file from robot to your program
		/// </summary>
		/// <param name="name">File to load</param>
		public RobotFileContentData GetFile(string name, HighSpeedEServerClientBase.GetFileProgressDelegate onGetFileProgress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Connect robot IP address or host name
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Indicates if the connection is enabled
		/// </summary>
		public bool Connected { get; }
	}
}
