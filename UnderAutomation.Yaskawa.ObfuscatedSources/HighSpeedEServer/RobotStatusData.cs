//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Contains the current operational status of the robot controller.
	/// Provides information about the robot's mode, running state, and safety conditions.
	/// Retrieved using the status information reading command.
	/// </summary>
	public class RobotStatusData : RobotData {

		/// <summary>
		/// Gets whether the robot is in step (single-step) execution mode.
		/// When true, the robot executes one instruction at a time.
		/// </summary>
		public bool Step { get; }

		/// <summary>
		/// Gets whether the robot is in cycle execution mode.
		/// When true, the robot executes one complete cycle then stops.
		/// </summary>
		public bool Cycle { get; }

		/// <summary>
		/// Gets whether the robot is in automatic operation mode.
		/// When true, the robot can operate automatically without pendant interaction.
		/// </summary>
		public bool Automatic { get; }

		/// <summary>
		/// Gets whether the robot is currently running (executing a job).
		/// </summary>
		public bool Running { get; }

		/// <summary>
		/// Gets whether the robot is in guard safe operation mode.
		/// Indicates collaborative/safety-rated operation mode is active.
		/// </summary>
		public bool InGuardSafeOperation { get; }

		/// <summary>
		/// Gets whether the robot is in teach mode.
		/// In teach mode, the robot can be manually positioned and jobs can be edited.
		/// </summary>
		public bool Teach { get; }

		/// <summary>
		/// Gets whether the robot is in play mode.
		/// In play mode, the robot can execute programmed jobs.
		/// </summary>
		public bool Play { get; }

		/// <summary>
		/// Gets whether remote command mode is enabled.
		/// When true, the robot accepts commands from external sources (including this API).
		/// </summary>
		public bool CommandRemote { get; }

		/// <summary>
		/// Gets whether the robot is held by the programming pendant.
		/// Operator has pressed hold on the pendant.
		/// </summary>
		public bool InHoldStatusPendant { get; }

		/// <summary>
		/// Gets whether the robot is held by an external hold signal.
		/// External safety circuit has triggered a hold condition.
		/// </summary>
		public bool InHoldStatusExternally { get; }

		/// <summary>
		/// Gets whether the robot is held by a command (software hold).
		/// A hold command was issued via the API or job instruction.
		/// </summary>
		public bool InHoldStatusByCommand { get; }

		/// <summary>
		/// Gets whether an alarm is currently active.
		/// Check GetAlarm() for detailed alarm information.
		/// </summary>
		public bool Alarming { get; }

		/// <summary>
		/// Gets whether an error condition is occurring.
		/// Errors may prevent normal operation until resolved.
		/// </summary>
		public bool ErrorOccurring { get; }

		/// <summary>
		/// Gets whether servo power is enabled.
		/// Servo must be ON for the robot to move.
		/// </summary>
		public bool ServoOn { get; }
	}
}
