//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Provides robot control commands: alarm reset, servo, hold, cycle, job and display.
	/// </summary>
	public interface IRobotControl : IYaskawaClient {

		/// <summary>
		/// Resets the current alarm condition.
		/// </summary>
		void AlarmReset()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Enables or disables servo power. Servo must be ON for the robot to move.
		/// </summary>
		/// <param name="enable">True to enable servo power, false to disable.</param>
		void SetServo(bool enable)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the hold state of the robot. When hold is ON, robot motion is paused.
		/// </summary>
		/// <param name="enable">True to hold (pause), false to release hold.</param>
		void SetHold(bool enable)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Locks or unlocks the teach pendant.
		/// </summary>
		/// <param name="locked">True to lock the teach pendant, false to unlock.</param>
		void SetTeachPendantLockState(bool locked)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the execution cycle type (Step, One Cycle, or Automatic).
		/// </summary>
		/// <param name="cycle">The target cycle type.</param>
		void SetCycle(RobotCycleType cycle)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts execution of the currently selected job.
		/// </summary>
		void StartJob()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Selects a job for execution and positions to a specific line.
		/// </summary>
		/// <param name="jobName">Job name to select.</param>
		/// <param name="line">Line number to position to.</param>
		void SelectJob(string jobName, int line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Displays a popup message on the robot programming pendant.
		/// </summary>
		/// <param name="message">The message to display.</param>
		void Display(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
