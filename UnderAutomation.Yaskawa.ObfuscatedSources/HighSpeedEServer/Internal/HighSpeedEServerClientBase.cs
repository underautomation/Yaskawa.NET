//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using HighSpeedEServer;
using Common;
using System;

namespace HighSpeedEServer.Internal {
	/// <summary>
	/// Base class implementing the High Speed Ethernet Server protocol for Yaskawa robot communication.
	/// Provides methods for reading robot status, positions, variables, and executing commands via UDP.
	/// </summary>
	public abstract class HighSpeedEServerClientBase {

		/// <summary>
		/// Delegate for receiving file download progress notifications.
		/// </summary>
		/// <param name="progress">Progress information including bytes downloaded.</param>
		public delegate void GetFileProgressDelegate(GetFileProgress progress);

		/// <summary>
		/// Delegate for receiving file upload progress notifications.
		/// </summary>
		/// <param name="progress">Progress information including bytes loaded and total size.</param>
		public delegate void LoadFileProgressDelegate(LoadFileProgress progress);

		/// <summary>
		/// Closes the connection to the robot controller and releases network resources.
		/// </summary>
		public void Close()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads alarm information from the robot controller.
		/// Retrieves alarm code, type, occurrence time, and descriptive text.
		/// </summary>
		/// <param name="alarm">Which alarm to retrieve from the alarm history (latest, second latest, etc.).</param>
		/// <returns>Alarm data containing code, type, time, and message text.</returns>
		public RobotAlarmData GetAlarm(RobotRecentAlarm alarm)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current operational status of the robot controller.
		/// Returns information about mode (teach/play), running state, hold status, alarms, and servo power.
		/// </summary>
		/// <returns>Status data containing boolean flags for various robot states.</returns>
		public RobotStatusData GetStatusInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads information about the currently selected and executing job (program).
		/// Returns job name, current line, step, and speed override percentage.
		/// </summary>
		/// <returns>Job data containing name, line number, step, and speed override.</returns>
		public RobotJobData GetExecutingJobInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the job call stack for a specific task on the robot controller.
		/// Returns the current nesting of CALL instructions, from the outermost job to the currently executing one.
		/// </summary>
		/// <param name="taskNumber">Task number to query 0 for Master Job, 1 to 15 for sub-tasks. Default: 0 (Master Job).</param>
		/// <returns>Job stack data containing the array of job names, outermost first.</returns>
		public RobotJobStackData GetJobStack(int taskNumber = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads axis configuration information for the default robot control group.
		/// Returns axis type names for each of the 8 possible axes.
		/// </summary>
		/// <returns>Axis configuration data with axis type names.</returns>
		public RobotAxisConfigData GetConfigurationInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads axis configuration information for a specified control group.
		/// Returns axis type names (e.g., "S", "L", "U", "R", "B", "T") for each axis.
		/// </summary>
		/// <param name="type">Control group to query (robot, base, station).</param>
		/// <returns>Axis configuration data with axis type names.</returns>
		public RobotAxisConfigData GetConfigurationInformation(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current robot Cartesian position (TCP position and orientation).
		/// Coordinates are returned in millimeters for X, Y, Z and degrees for Rx, Ry, Rz.
		/// </summary>
		/// <returns>Cartesian position data with coordinates in mm and degrees.</returns>
		public RobotPositionCartesianData GetRobotCartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current robot joint position in pulse (encoder) values.
		/// Returns raw pulse values for all robot axes.
		/// </summary>
		/// <returns>Joint position data with axis values in encoder pulses.</returns>
		public RobotPositionIntData GetRobotJointPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads position data for a specified control group.
		/// Can read robot, base, or station position data depending on the control group specified.
		/// </summary>
		/// <param name="type">Control group to query.</param>
		/// <returns>Position data with axis values (format depends on control group type).</returns>
		public RobotPositionIntData GetRobotPosition(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the position error (difference between commanded and actual position) for the default robot.
		/// Values indicate servo tracking error in pulse units.
		/// </summary>
		/// <returns>Position error data with axis error values in pulses.</returns>
		public RobotAxisIntData GetPositionError()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the position error for a specified control group.
		/// Position error indicates the difference between commanded and actual position.
		/// </summary>
		/// <param name="type">Control group to query.</param>
		/// <returns>Position error data with axis error values in pulses.</returns>
		public RobotAxisIntData GetPositionError(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current torque values for the default robot's servo motors.
		/// Torque values indicate motor load as a percentage of rated torque.
		/// </summary>
		/// <returns>Torque data with axis torque values (typically as percentage).</returns>
		public RobotAxisIntData GetTorque()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current torque values for a specified control group's servo motors.
		/// Torque values indicate motor load as a percentage of rated torque.
		/// </summary>
		/// <param name="type">Control group to query.</param>
		/// <returns>Torque data with axis torque values.</returns>
		public RobotAxisIntData GetTorque(RobotControlGroup type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Resets alarms or cancels errors on the robot controller.
		/// Use Reset to clear alarm conditions after resolving the cause.
		/// Use Cancel for recoverable errors that don't require alarm reset.
		/// </summary>
		/// <param name="type">Type of reset operation (Reset or Cancel).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader AlarmReset(AlarmResetType type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Executes hold/servo/HLock on/off commands.
		/// For servo control, this enables or disables motor power to the robot.
		/// Servo must be ON for the robot to move.
		/// </summary>
		/// <param name="command">Type of command (Hold, Servo, or HLock).</param>
		/// <param name="value">True to enable (ON), false to disable (OFF).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader ServoCommand(OnOffCommandType command, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Switches the robot execution mode between Step, Cycle, and Continuous.
		/// </summary>
		/// <param name="command">Target execution mode.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader SwitchingCommand(SwitchingCommands command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Displays a popup message on the robot programming pendant.
		/// Message will appear as a notification to the operator.
		/// </summary>
		/// <param name="message">Message text to display (maximum 24 characters).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader Display(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts execution of the currently selected job.
		/// The job must be selected first using SelectJob before calling this method.
		/// Servo must be ON and the robot must not be in alarm state.
		/// </summary>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader StartJob()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Selects a job for execution and optionally positions to a specific line.
		/// Call StartJob after selecting to begin execution.
		/// </summary>
		/// <param name="job">Job name (maximum 32 characters, typically ends with .JBI extension).</param>
		/// <param name="line">Line number within the job to position to (1-based). Use 0 for beginning.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader SelectJob(string job, int line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Retrieves management time statistics from the robot controller.
		/// Can query various timing metrics like control power ON time, servo ON time, etc.
		/// </summary>
		/// <param name="type">Type of management time to retrieve (ControlPowerOnTime, ServoPowerOnTime, etc.).</param>
		/// <param name="index">Index for job-specific timing (0 for main job, or job index).</param>
		/// <returns>Management time data including start time and elapsed time strings.</returns>
		public RobotManagementTimeData GetManagementTime(ManagementTimeType type, int index = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Retrieves system information about the default robot system (R1).
		/// Returns software version, robot name, and parameter file information.
		/// </summary>
		/// <returns>System information for the default robot.</returns>
		public RobotSystemInformation GetSystemInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Retrieves system information for a specific robot system or control group.
		/// Use for multi-robot controllers or to query specific axes groups.
		/// </summary>
		/// <param name="type">Robot system type specifier (e.g., R1, R2, S1, etc.).</param>
		/// <returns>System information including software version, robot name, and parameter file.</returns>
		public RobotSystemInformation GetSystemInformation(RobotSystemTypeData type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a system parameter from the robot controller.
		/// </summary>
		/// <param name="type">Category of the system parameter.</param>
		/// <param name="number">Parameter number within the category.</param>
		/// <param name="group">Group number. Leave at 0 for types that do not require a group
		/// (<xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.S2C" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.S3C" data-throw-if-not-resolved="false"></xref>,
		/// <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.S4C" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.RS" data-throw-if-not-resolved="false"></xref>).
		/// Must be specified for types <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.S1CG" data-throw-if-not-resolved="false"></xref>,
		/// <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.AP" data-throw-if-not-resolved="false"></xref>, and <xref href="UnderAutomation.Yaskawa.HighSpeedEServer.SystemParameterTypes.SE" data-throw-if-not-resolved="false"></xref>.</param>
		/// <returns>System parameter data containing the raw value.</returns>
		public RobotSystemParamData GetSystemParameter(SystemParameterTypes type, int number, int group = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple I/O bytes from the robot controller starting at a specified index.
		/// </summary>
		/// <param name="firstIndex">Starting I/O index. Valid ranges:
		/// 
		///             <ul><li>1-512: Robot user input signal</li><li>1001-1512: Robot user output signal</li><li>2001-2512: External input signal</li><li>2701-2956: Network input signal</li><li>3001-3512: External output signal</li><li>3701-3956: Network output signal</li><li>4001-4160: Robot system input signal</li><li>5001-5300: Robot system output signal</li><li>6001-6064: Interface panel input signal</li><li>7001-7999: Auxiliary relay signal</li><li>8001-8128: Robot control status signal</li></ul></param>
		/// <param name="count">Number of bytes to read (will be rounded up to nearest even number).</param>
		/// <returns>Plural data containing array of I/O byte values.</returns>
		public RobotIOData ReadIO(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes I/O bytes to the robot controller starting at a specified index.
		/// </summary>
		/// <param name="firstIndex">Starting I/O index. See ReadIO for valid ranges.</param>
		/// <param name="data">Data array to write (must contain an even number of elements).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteIO(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple I/O bytes from the robot controller using I/O group addressing.
		/// The starting byte index is computed from the I/O type and group number.
		/// </summary>
		/// <param name="type">The I/O signal category.</param>
		/// <param name="group">1-based group number within the I/O type.</param>
		/// <param name="count">Number of bytes to read (will be rounded up to nearest even number).</param>
		/// <returns>Plural data containing array of I/O byte values.</returns>
		public RobotIOData ReadIO(IOType type, ushort group, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes I/O bytes to the robot controller using I/O group addressing. By default, only Network Input can be written
		/// The starting byte index is computed from the I/O type and group number.
		/// </summary>
		/// <param name="type">The I/O signal category.</param>
		/// <param name="group">1-based group number within the I/O type.</param>
		/// <param name="data">Data array to write (must contain an even number of elements).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteIO(IOType type, ushort group, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes network input bytes to the robot controller
		/// </summary>
		/// <param name="group">1-based group number within the Network Inputs.</param>
		/// <param name="data">Data array to write (must contain an even number of elements).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteIoNetworkInput(ushort group, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple 16-bit register values (M variables) from the robot controller.
		/// Registers are used for general-purpose integer storage in robot programs.
		/// </summary>
		/// <param name="firstIndex">Starting register index.</param>
		/// <param name="count">Number of registers to read.</param>
		/// <returns>Plural data containing array of 16-bit register values.</returns>
		public RobotRegisterData ReadRegister(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes multiple 16-bit register values (M variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting register index.</param>
		/// <param name="data">Array of 16-bit values to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteRegister(int firstIndex, short[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple byte variables (B variables) from the robot controller.
		/// Byte variables are 8-bit unsigned values used for compact data storage.
		/// </summary>
		/// <param name="firstIndex">Starting byte variable index.</param>
		/// <param name="count">Number of bytes to read (will be rounded up to nearest even number).</param>
		/// <returns>Plural data containing array of byte values.</returns>
		public RobotByteVariableData ReadByte(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes byte variables (B variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting byte variable index.</param>
		/// <param name="data">Data to write (must contain an even number of elements).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteByte(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple integer variables (I variables) from the robot controller.
		/// Integer variables are 16-bit signed values (-32768 to 32767).
		/// </summary>
		/// <param name="firstIndex">Starting integer variable index.</param>
		/// <param name="count">Number of integer variables to read.</param>
		/// <returns>Plural data containing array of 16-bit integer values.</returns>
		public RobotIntegerVariableData ReadInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes integer variables (I variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting integer variable index.</param>
		/// <param name="data">Array of 16-bit integer values to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteInteger(int firstIndex, short[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple double-precision variables (D variables) from the robot controller.
		/// Note: The protocol actually transmits float values which are then cast to double.
		/// </summary>
		/// <param name="firstIndex">Starting double variable index.</param>
		/// <param name="count">Number of double variables to read.</param>
		/// <returns>Plural data containing array of double values.</returns>
		public RobotDoubleIntegerVariableData ReadDoubleInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes double-precision variables (D variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting double variable index.</param>
		/// <param name="data">Array of double values to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteDoubleInteger(int firstIndex, int[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple real (single-precision float) variables (R variables) from the robot controller.
		/// Real variables are 32-bit IEEE 754 floating-point values.
		/// </summary>
		/// <param name="firstIndex">Starting real variable index.</param>
		/// <param name="count">Number of real variables to read.</param>
		/// <returns>Plural data containing array of float values.</returns>
		public RobotRealVariableData ReadReal(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes real (single-precision float) variables (R variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting real variable index.</param>
		/// <param name="data">Array of float values to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteReal(int firstIndex, float[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple 16-byte string variables (S variables) from the robot controller.
		/// String variables are fixed-length, null-terminated ASCII strings.
		/// </summary>
		/// <param name="firstIndex">Starting string variable index.</param>
		/// <param name="count">Number of string variables to read.</param>
		/// <returns>Plural data containing array of string values.</returns>
		public RobotStringVariableData Read16BytesChar(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes 16-byte string variables (S variables) to the robot controller.
		/// Strings longer than 16 characters will be truncated.
		/// </summary>
		/// <param name="firstIndex">Starting string variable index.</param>
		/// <param name="data">Array of string values to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader Write16BytesChar(int firstIndex, string[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple position variables (P variables) from the robot controller.
		/// Position variables store complete robot poses including position, orientation, and configuration.
		/// </summary>
		/// <param name="firstIndex">Starting position variable index.</param>
		/// <param name="count">Number of position variables to read.</param>
		/// <returns>Plural data containing array of position data.</returns>
		public RobotPositionVariableData ReadPositionVariable(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes position variables (P variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting position variable index.</param>
		/// <param name="data">Array of position data to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WritePositionVariable(int firstIndex, RobotPositionIntData[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes position variables (P variables) to the robot controller using generic type.
		/// Provided for backward compatibility with existing code.
		/// </summary>
		/// <param name="firstIndex">Starting position variable index.</param>
		/// <param name="data">Array of position data to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WritePositionVariable(int firstIndex, RobotPositionData<int>[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple base position variables (BP variables) from the robot controller.
		/// Base position variables define reference coordinate frames for robot operations.
		/// </summary>
		/// <param name="firstIndex">Starting base position variable index.</param>
		/// <param name="count">Number of base position variables to read.</param>
		/// <returns>Plural data containing array of base position data.</returns>
		public RobotBasePositionVariableData ReadBasePosition(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes base position variables (BP variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting base position variable index.</param>
		/// <param name="data">Array of base position data to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteBasePosition(int firstIndex, RobotBasePositionData[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple external axis variables (EX variables) from the robot controller.
		/// External axis variables store positions for additional axes beyond the main robot arm.
		/// </summary>
		/// <param name="firstIndex">Starting external axis variable index.</param>
		/// <param name="count">Number of external axis variables to read.</param>
		/// <returns>Plural data containing array of external axis position data.</returns>
		public RobotExternalAxisVariableData ReadExternalPosition(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes external axis variables (EX variables) to the robot controller.
		/// </summary>
		/// <param name="firstIndex">Starting external axis variable index.</param>
		/// <param name="data">Array of external axis position data to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteExternalPosition(int firstIndex, RobotExternalAxisData[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes external axis variables (EX variables) to the robot controller using generic type.
		/// Provided for backward compatibility with existing code.
		/// </summary>
		/// <param name="firstIndex">Starting external axis variable index.</param>
		/// <param name="data">Array of external axis position data to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader WriteExternalPosition(int firstIndex, RobotAxisRawData<int>[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Retrieves extended alarm information including sub-code character strings.
		/// Provides more detailed information than GetAlarm for troubleshooting.
		/// </summary>
		/// <param name="alarm">Alarm index to retrieve (Alarm1 through Alarm4).</param>
		/// <returns>Extended alarm data including code, timing, text description, and additional information.</returns>
		public RobotAlarmDataExtended GetAlarmExtended(RobotRecentAlarm alarm)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Commands the robot to move to a Cartesian position (X, Y, Z, Rx, Ry, Rz).
		/// Movement is relative to the specified coordinate system.
		/// </summary>
		/// <param name="x">X coordinate in millimeters.</param>
		/// <param name="y">Y coordinate in millimeters.</param>
		/// <param name="z">Z coordinate in millimeters.</param>
		/// <param name="rx">Rotation around X axis in degrees.</param>
		/// <param name="ry">Rotation around Y axis in degrees.</param>
		/// <param name="rz">Rotation around Z axis in degrees.</param>
		/// <param name="classification">Speed unit classification (percent or linear speed).</param>
		/// <param name="speed">Movement speed in the specified units.</param>
		/// <param name="coordinate">Coordinate system for the movement (Base, Robot, User, Tool).</param>
		/// <param name="posture">Robot posture/configuration (RCONF) for the target position. Null for default.</param>
		/// <param name="commandtype">Type of motion command (increment, absolute, etc.).</param>
		/// <param name="RobotControlGroup">Robot control group number (typically 1 for main robot).</param>
		/// <param name="StationControlGroup">Station control group number (0 if not applicable).</param>
		/// <param name="tool">Tool center point number to use.</param>
		/// <param name="userCoordinate">User coordinate number (for User coordinate system).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader MoveCartesian(double x, double y, double z, double rx, double ry, double rz, PositionCommandClassification classification, double speed, PositionCommandOperationCoordinate coordinate, RobotPosture posture = null, PositionCommandType commandtype = PositionCommandType.StraightIncrement, int RobotControlGroup = 1, int StationControlGroup = 0, int tool = 0, int userCoordinate = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Commands the robot to move using joint (pulse) positions.
		/// This specifies the position of each axis directly in encoder pulses.
		/// </summary>
		/// <param name="axesPulse">Array of axis positions in encoder pulses (up to 8 axes).</param>
		/// <param name="classification">Speed unit classification (percent or angular speed).</param>
		/// <param name="speed">Movement speed in the specified units.</param>
		/// <param name="commandtype">Type of motion command (increment, absolute, etc.).</param>
		/// <param name="RobotControlGroup">Robot control group number (typically 1 for main robot).</param>
		/// <param name="StationControlGroup">Station control group number (typically 1 for station axes).</param>
		/// <param name="tool">Tool center point number to use.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader MoveJoints(int[] axesPulse, PositionCommandClassification classification, double speed, PositionCommandType commandtype = PositionCommandType.StraightIncrement, int RobotControlGroup = 1, int StationControlGroup = 1, int tool = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads multiple 32-byte string variables (S variables) from the robot controller (DX200 only).
		/// Extended string variables for longer text storage than 16-byte variants.
		/// </summary>
		/// <param name="firstIndex">Starting string variable index.</param>
		/// <param name="count">Number of string variables to read.</param>
		/// <returns>Plural data containing array of string values.</returns>
		public RobotStringVariableData Read32BytesChar(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes 32-byte string variables (S variables) to the robot controller.
		/// Strings longer than 32 characters will be truncated.
		/// </summary>
		/// <param name="firstIndex">Starting string variable index.</param>
		/// <param name="data">Array of string values to write.</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader Write32BytesChar(int firstIndex, string[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a file from the robot controller's file system.
		/// Use with caution as deleted files cannot be recovered.
		/// </summary>
		/// <param name="name">File name to delete (e.g., "TEST.JBI" for a job file).</param>
		/// <returns>Response header indicating success.</returns>
		public RobotDataHeader DeleteFile(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads (loads) a file from the PC to the robot controller.
		/// Large files are automatically split into 479-byte chunks for transmission.
		/// </summary>
		/// <param name="name">Target file name on the robot (e.g., "TEST.JBI" for a job file).</param>
		/// <param name="content">File content as a string (typically job file text content).</param>
		/// <param name="onLoadFileProgress">Optional callback for progress notifications.</param>
		/// <returns>Array of response headers for each chunk transmitted.</returns>
		public RobotDataHeader[] LoadFile(string name, string content, HighSpeedEServerClientBase.LoadFileProgressDelegate onLoadFileProgress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Retrieves a list of files matching a pattern from the robot controller.
		/// Supports wildcards for matching multiple files.
		/// </summary>
		/// <param name="pattern">File search pattern (e.g., "*.JBI" to list all job files, "*.DAT" for data files).</param>
		/// <returns>File list data containing an array of matching file names.</returns>
		public RobotFileListData GetFileList(string pattern)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads (saves) a file from the robot controller to the PC.
		/// Large files are received in multiple blocks and automatically reassembled.
		/// Special use case : to download CMOS.BIN, first perform a CMOS backup using BatchDataBackup, then use GetFile with the backup file path.
		/// </summary>
		/// <param name="name">File name to download from the robot (e.g., "TEST.JBI").</param>
		/// <param name="onGetFileProgress">Optional callback for progress notifications.</param>
		/// <returns>File content data including the file name and text content.</returns>
		public RobotFileContentData GetFile(string name, HighSpeedEServerClientBase.GetFileProgressDelegate onGetFileProgress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Performs a backup of the robot's CMOS. The CMOS.BIN file is copied locally in the robot controller to "/SPDRC/CMOSBK.BIN".
		/// The operation can take several seconds to complete. After this command, the backup file can be downloaded using GetFile("/SPDRC/CMOSBK.BIN").
		/// To enable this command : in "MANAGEMENT MODE", select {SETUP} - {AUTO BACKUP SET} and set "DEVICE" to "RAMDISK".
		/// If this menu is not available, Reboot the controller in Maintenance Mode and set System / Setup / OPTION FUNCTION / AUTOBACKUP to "Used", then do a "Safety board flash reset" from File / Initialize
		/// </summary>
		/// <param name="file">Controller backup file path for CMOS.BIN copy</param>
		public RobotDataHeader BatchDataBackup(string file = "/SPDRV/CMOSBK.BIN")
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected HighSpeedEServerClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the IP address or hostname of the connected robot controller.
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Gets a value indicating whether the client is connected to a robot controller.
		/// Note: Since UDP is connectionless, this only indicates if the socket is configured.
		/// </summary>
		public bool Connected { get; }
	}
}
