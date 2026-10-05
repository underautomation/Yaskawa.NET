//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Yaskawa.Common {
	/// <summary>
	/// Represents the operational status of a Yaskawa robot controller.
	/// Common status flags shared across all communication protocols.
	/// </summary>
	public interface IStatusData {

		/// <summary>
		/// Step execution mode active.
		/// </summary>
		bool Step { get; }

		/// <summary>
		/// Cycle execution mode active.
		/// </summary>
		bool Cycle { get; }

		/// <summary>
		/// Automatic operation mode active.
		/// </summary>
		bool Automatic { get; }

		/// <summary>
		/// Currently executing a job.
		/// </summary>
		bool Running { get; }

		/// <summary>
		/// Manual teach mode active.
		/// </summary>
		bool Teach { get; }

		/// <summary>
		/// Program playback mode active.
		/// </summary>
		bool Play { get; }

		/// <summary>
		/// Remote command mode enabled.
		/// </summary>
		bool CommandRemote { get; }

		/// <summary>
		/// Servo power is on.
		/// </summary>
		bool ServoOn { get; }

		/// <summary>
		/// An error condition is occurring.
		/// </summary>
		bool ErrorOccurring { get; }

		/// <summary>
		/// An alarm is active.
		/// </summary>
		bool Alarming { get; }

		/// <summary>
		/// Hold state triggered by software command.
		/// </summary>
		bool InHoldStatusByCommand { get; }

		/// <summary>
		/// Hold state triggered by external signal.
		/// </summary>
		bool InHoldStatusExternally { get; }

		/// <summary>
		/// Hold state triggered by teach pendant.
		/// </summary>
		bool InHoldStatusPendant { get; }
	}
}
