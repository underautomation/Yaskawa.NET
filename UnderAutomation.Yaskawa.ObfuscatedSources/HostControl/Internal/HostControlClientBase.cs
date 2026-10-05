//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.HostControl.Internal {
	/// <summary>
	/// Base class implementing the Host Control protocol for Yaskawa robot communication.
	/// Provides methods for reading robot status, positions, variables, and executing commands.
	/// </summary>
	public abstract class HostControlClientBase : IRobotClient, IStatusReader, IPositionReader, IAlarmReader, IRobotControl, IIOAccess, IVariableAccess, ITorqueReader, IMotionControl, IYaskawaClient {

		/// <summary>
		/// Closes the connection to the robot controller and releases resources.
		/// </summary>
		public abstract void Close();

		/// <summary>
		/// Reads the codes of the active error and alarms from the robot controller.
		/// Index 0 of the arrays is the error, indexes 1 to 4 are the alarms.
		/// </summary>
		/// <returns>Alarm data containing codes and additional information.</returns>
		public HostControlAlarmData GetAlarm()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current operational status of the robot controller.
		/// Returns information about mode (teach/play), running state, hold status, alarms, and servo power.
		/// </summary>
		/// <returns>Status data containing boolean flags for various robot states.</returns>
		public HostControlStatusData GetStatusInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads information about the currently selected and executing job (program).
		/// Returns job name, current line, and step.
		/// </summary>
		/// <returns>Job data containing name, line number, and step.</returns>
		public HostControlJobData GetExecutingJobInformation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current control group configuration.
		/// Returns robot group bits, station group bits, and current task number.
		/// </summary>
		/// <returns>Control group data.</returns>
		public HostControlGroupData GetControlGroup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current robot joint position in pulse (encoder) values.
		/// Returns raw pulse values for all robot axes (S, L, U, R, B, T, and external axes).
		/// </summary>
		/// <returns>Joint position data with axis values in encoder pulses.</returns>
		public HostControlJointPositionData GetRobotJointPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current robot Cartesian position (TCP position and orientation).
		/// Coordinates are returned in millimeters for X, Y, Z and degrees for Rx, Ry, Rz.
		/// </summary>
		/// <param name="coordinateSystem">The coordinate system for the position (default: Base).</param>
		/// <param name="includeExternalAxes">Whether to include external axis positions (default: false).</param>
		/// <returns>Cartesian position data with coordinates in mm and degrees.</returns>
		public HostControlCartesianPositionData GetRobotCartesianPosition(HostControlCoordinateSystem coordinateSystem = HostControlCoordinateSystem.Base, bool includeExternalAxes = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the hold state of the robot.
		/// When hold is ON, robot motion is paused. When OFF, motion can resume.
		/// </summary>
		/// <param name="enable">True to hold (pause), false to release hold.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetHold(bool enable)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Resets the current alarm condition.
		/// The cause of the alarm must be resolved before reset will succeed.
		/// Command remote must be enabled on the controller.
		/// </summary>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse AlarmReset()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Cancels the current error condition.
		/// Used for recoverable errors that don't require full alarm reset.
		/// </summary>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse ErrorCancel()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the robot operation mode (Teach or Play).
		/// </summary>
		/// <param name="mode">The target mode.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetMode(RobotMode mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the execution cycle type (Step, One Cycle, or Automatic).
		/// </summary>
		/// <param name="cycle">The target cycle type.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetCycle(RobotCycleType cycle)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enables or disables servo power.
		/// Servo must be ON for the robot to move. Uses extended timeout for power-on.
		/// </summary>
		/// <param name="enable">True to enable servo power, false to disable.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetServo(bool enable)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Locks or unlocks the operations from the teach pendant and from the I/O operation signals.
		/// The emergency stop of the teach pendant stays active. Command remote must be enabled on the controller.
		/// </summary>
		/// <param name="locked">True to enable interlock, false to disable.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetTeachPendantLockState(bool locked)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Displays a message on the remote display of the teach pendant.
		/// Command remote must be enabled on the controller.
		/// </summary>
		/// <param name="message">The message to display (max 30 characters).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse Display(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts job execution.
		/// Starts the currently selected job, or starts a specific job if specified.
		/// </summary>
		/// <param name="jobName">Optional job name to start. If null, starts the current job.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse StartJob(string jobName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Changes the control group selection.
		/// </summary>
		/// <param name="robotGroup">Robot group bits (bit 0 = R1, bit 1 = R2, etc.).</param>
		/// <param name="stationGroup">Station group bits (bit 0 = S1, bit 1 = S2, etc.).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetControlGroup(int robotGroup, int stationGroup)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Changes the current task selection.
		/// </summary>
		/// <param name="task">Task number (0 = Master, 1-15 = Sub tasks).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetTask(int task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the robot to a Cartesian position using joint interpolation.
		/// Joint motion is faster but the path is not linear.
		/// </summary>
		/// <param name="speedPercent">Speed percentage (0-100).</param>
		/// <param name="coordinateSystem">Coordinate system for the target position.</param>
		/// <param name="x">X position in mm.</param>
		/// <param name="y">Y position in mm.</param>
		/// <param name="z">Z position in mm.</param>
		/// <param name="rx">Rx rotation in degrees.</param>
		/// <param name="ry">Ry rotation in degrees.</param>
		/// <param name="rz">Rz rotation in degrees.</param>
		/// <param name="type">Robot posture/configuration type.</param>
		/// <param name="toolNumber">Tool number (0-63).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse MoveJoint(int speedPercent, HostControlCoordinateSystem coordinateSystem, double x, double y, double z, double rx, double ry, double rz, int type = 0, int toolNumber = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the robot to a Cartesian position using linear interpolation.
		/// Linear motion follows a straight line path.
		/// </summary>
		/// <param name="speedType">Speed type (percentage or mm/s).</param>
		/// <param name="speed">Speed value.</param>
		/// <param name="coordinateSystem">Coordinate system for the target position.</param>
		/// <param name="x">X position in mm.</param>
		/// <param name="y">Y position in mm.</param>
		/// <param name="z">Z position in mm.</param>
		/// <param name="rx">Rx rotation in degrees.</param>
		/// <param name="ry">Ry rotation in degrees.</param>
		/// <param name="rz">Rz rotation in degrees.</param>
		/// <param name="type">Robot posture/configuration type.</param>
		/// <param name="toolNumber">Tool number (0-63).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse MoveLinear(HostControlSpeedType speedType, double speed, HostControlCoordinateSystem coordinateSystem, double x, double y, double z, double rx, double ry, double rz, int type = 0, int toolNumber = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the robot incrementally using linear interpolation.
		/// Movement is relative to the current position.
		/// </summary>
		/// <param name="speedType">Speed type (percentage or mm/s).</param>
		/// <param name="speed">Speed value.</param>
		/// <param name="coordinateSystem">Coordinate system for the increment.</param>
		/// <param name="dx">X increment in mm.</param>
		/// <param name="dy">Y increment in mm.</param>
		/// <param name="dz">Z increment in mm.</param>
		/// <param name="drx">Rx increment in degrees.</param>
		/// <param name="dry">Ry increment in degrees.</param>
		/// <param name="drz">Rz increment in degrees.</param>
		/// <param name="toolNumber">Tool number (0-63).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse MoveIncremental(HostControlSpeedType speedType, double speed, HostControlCoordinateSystem coordinateSystem, double dx, double dy, double dz, double drx, double dry, double drz, int toolNumber = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the robot to a pulse position using joint interpolation.
		/// </summary>
		/// <param name="speedPercent">Speed percentage (0-100).</param>
		/// <param name="s">S axis position in pulses.</param>
		/// <param name="l">L axis position in pulses.</param>
		/// <param name="u">U axis position in pulses.</param>
		/// <param name="r">R axis position in pulses.</param>
		/// <param name="b">B axis position in pulses.</param>
		/// <param name="t">T axis position in pulses.</param>
		/// <param name="toolNumber">Tool number (0-63).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse MovePulseJoint(int speedPercent, int s, int l, int u, int r, int b, int t, int toolNumber = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the robot to a pulse position using linear interpolation.
		/// </summary>
		/// <param name="speedType">Speed type (percentage or mm/s).</param>
		/// <param name="speed">Speed value.</param>
		/// <param name="s">S axis position in pulses.</param>
		/// <param name="l">L axis position in pulses.</param>
		/// <param name="u">U axis position in pulses.</param>
		/// <param name="r">R axis position in pulses.</param>
		/// <param name="b">B axis position in pulses.</param>
		/// <param name="t">T axis position in pulses.</param>
		/// <param name="toolNumber">Tool number (0-63).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse MovePulseLinear(HostControlSpeedType speedType, double speed, int s, int l, int u, int r, int b, int t, int toolNumber = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads I/O signals from the robot controller. Each byte holds 8 signals.
		/// </summary>
		/// <param name="startAddress">Contact number of the first signal, as displayed on the teach pendant
		///             (for example 10010 for #10010). Use a number that ends with 0, so that each byte is one group of 8 signals.</param>
		/// <param name="count">Number of bytes to read (1 to 256).</param>
		/// <returns>I/O data containing the read values.</returns>
		public HostControlIOData ReadIO(int startAddress, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes I/O signals to the robot controller. Each byte holds 8 signals.
		/// By default, the controller accepts only the network input signals (#27010 to #29567).
		/// </summary>
		/// <param name="startAddress">Contact number of the first signal, as displayed on the teach pendant
		///             (for example 27010 for #27010). Use a number that ends with 0, so that each byte is one group of 8 signals.</param>
		/// <param name="data">Data bytes to write (1 to 256 bytes).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse WriteIO(int startAddress, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads byte (B) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of byte values.</returns>
		public byte[] ReadByte(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes byte (B) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Byte values to write.</param>
		public void WriteByte(int firstIndex, byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads integer (I) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of 16-bit signed integer values.</returns>
		public short[] ReadInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes integer (I) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Integer values to write.</param>
		public void WriteInteger(int firstIndex, short[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads double integer (D) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of 32-bit signed integer values.</returns>
		public int[] ReadDoubleInteger(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes double integer (D) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Double integer values to write.</param>
		public void WriteDoubleInteger(int firstIndex, int[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads real (R) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of floating-point values.</returns>
		public float[] ReadReal(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes real (R) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">Real values to write.</param>
		public void WriteReal(int firstIndex, float[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads 16-byte string (S) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="count">Number of variables to read.</param>
		/// <returns>Array of string values.</returns>
		public string[] Read16BytesChar(int firstIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes 16-byte string (S) variables starting at the specified index.
		/// </summary>
		/// <param name="firstIndex">Starting variable index.</param>
		/// <param name="data">String values to write.</param>
		public void Write16BytesChar(int firstIndex, string[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads the job directory listing from the robot controller.
		/// </summary>
		/// <param name="jobNameFilter">Job name filter (use "*" for all jobs, or specify a pattern).</param>
		/// <returns>Job directory data containing the list of job names.</returns>
		public HostControlJobDirectoryData GetJobDirectory(string jobNameFilter = "*")
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads user coordinate frame data from the robot controller.
		/// Returns the three reference points (ORG, XX, XY) defining the user coordinate system.
		/// </summary>
		/// <param name="userCoordinateNumber">User coordinate number (2-64).</param>
		/// <returns>User frame data containing the coordinate transformation.</returns>
		public HostControlUserFrameData GetUserFrame(int userCoordinateNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes user coordinate frame data to the robot controller.
		/// Defines a user coordinate system using three reference points (ORG, XX, XY).
		/// </summary>
		/// <param name="userCoordinateNumber">User coordinate number (2-64).</param>
		/// <param name="frame">User frame data containing the reference points.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetUserFrame(int userCoordinateNumber, HostControlUserFrameData frame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a specified job from the robot controller.
		/// </summary>
		/// <param name="jobName">Job name to delete, or "*" to delete all jobs.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse DeleteJob(string jobName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets a specified job as the master job and execution job.
		/// </summary>
		/// <param name="jobName">Job name to set as master.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetMasterJob(string jobName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the job name and line number for execution.
		/// </summary>
		/// <param name="jobName">Job name to select.</param>
		/// <param name="line">Line number to set (0-9999).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SelectJob(string jobName, int line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Waits for the current job to complete or the specified timeout to elapse.
		/// No response is sent until the job completes or the timeout expires.
		/// </summary>
		/// <param name="timeoutSeconds">Waiting time in seconds (-1 for infinite, up to 32767).</param>
		/// <returns>True if the job completed, false if stopped or timed out.</returns>
		public bool WaitForJobCompletion(int timeoutSeconds = -1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a specified job to a relative job of a specified coordinate system.
		/// Requires the relative job function on the robot controller.
		/// </summary>
		/// <param name="jobName">Name of the job to convert.</param>
		/// <param name="coordinateSystem">Target coordinate system for conversion.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse ConvertToRelativeJob(string jobName, HostControlCoordinateSystem coordinateSystem)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a specified job to a standard job (pulse job).
		/// Requires the relative job function on the robot controller.
		/// </summary>
		/// <param name="jobName">Name of the job to convert.</param>
		/// <param name="convertingMethod">Converting method: 0 = Previous step (B-axis sign same), 1 = Type regarded, 2 = Previous step (R-axis travel minimum).</param>
		/// <param name="referencePositionVariable">Position variable number for the first step conversion reference.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse ConvertToStandardJob(string jobName, int convertingMethod, int referencePositionVariable)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current torque values of all robot axes.
		/// Returns values as a percentage of the maximum rated torque.
		/// </summary>
		/// <returns>Torque data containing values for each axis.</returns>
		public HostControlTorqueData GetTorque()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the maximum torque values of all robot axes.
		/// Returns values as a percentage of the maximum rated torque.
		/// </summary>
		/// <returns>Torque data containing maximum values for each axis.</returns>
		public HostControlTorqueData GetMaxTorque()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the encoder temperature values of all robot axes.
		/// </summary>
		/// <returns>Encoder temperature data containing values for each axis in degrees Celsius.</returns>
		public HostControlEncoderTemperatureData GetEncoderTemperature()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the system time from the robot controller.
		/// </summary>
		/// <returns>System time data containing year, date, time, seconds and day of week.</returns>
		public HostControlSystemTimeData GetSystemTime()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the absolute encoder position of a specific axis.
		/// </summary>
		/// <param name="axisNumber">Axis number (0-based).</param>
		/// <returns>The absolute encoder position value.</returns>
		public long GetAbsoluteEncoderPosition(int axisNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes the absolute encoder data for a specific axis.
		/// </summary>
		/// <param name="axisNumber">Axis number (0-based).</param>
		/// <param name="value">The absolute encoder value to write.</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetAbsoluteEncoderPosition(int axisNumber, long value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the coordinate frame type used for position display on the pendant.
		/// </summary>
		/// <param name="frameType">Frame type (0 = Base, 1 = Robot, etc.).</param>
		/// <returns>Response indicating success or failure.</returns>
		public HostControlResponse SetFrameType(int frameType)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the active error and alarms with their text messages from the robot controller.
		/// Returns the error and up to 4 alarms, each with its code, sub-code and message.
		/// </summary>
		/// <returns>Error and alarm data with the text message of each entry.</returns>
		public HostControlAlarmStringData GetAlarmWithMessages()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected HostControlClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the address of the connected robot controller (IP address).
		/// </summary>
		public abstract string Address { get; }

		/// <summary>
		/// Gets a value indicating whether the client is connected to a robot controller.
		/// </summary>
		public abstract bool Connected { get; }
	}
}
