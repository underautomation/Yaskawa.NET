import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotStatusData as robot_status_data

class RobotStatusData(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_status_data()
		else:
			self._instance = _internal
	@property
	def step(self) -> bool:
		return self._instance.Step
	@step.setter
	def step(self, value: bool):
		self._instance.Step = value
	@property
	def cycle(self) -> bool:
		return self._instance.Cycle
	@cycle.setter
	def cycle(self, value: bool):
		self._instance.Cycle = value
	@property
	def automatic(self) -> bool:
		return self._instance.Automatic
	@automatic.setter
	def automatic(self, value: bool):
		self._instance.Automatic = value
	@property
	def running(self) -> bool:
		return self._instance.Running
	@running.setter
	def running(self, value: bool):
		self._instance.Running = value
	@property
	def in_guard_safe_operation(self) -> bool:
		return self._instance.InGuardSafeOperation
	@in_guard_safe_operation.setter
	def in_guard_safe_operation(self, value: bool):
		self._instance.InGuardSafeOperation = value
	@property
	def teach(self) -> bool:
		return self._instance.Teach
	@teach.setter
	def teach(self, value: bool):
		self._instance.Teach = value
	@property
	def play(self) -> bool:
		return self._instance.Play
	@play.setter
	def play(self, value: bool):
		self._instance.Play = value
	@property
	def command_remote(self) -> bool:
		return self._instance.CommandRemote
	@command_remote.setter
	def command_remote(self, value: bool):
		self._instance.CommandRemote = value
	@property
	def in_hold_status_pendant(self) -> bool:
		return self._instance.InHoldStatusPendant
	@in_hold_status_pendant.setter
	def in_hold_status_pendant(self, value: bool):
		self._instance.InHoldStatusPendant = value
	@property
	def in_hold_status_externally(self) -> bool:
		return self._instance.InHoldStatusExternally
	@in_hold_status_externally.setter
	def in_hold_status_externally(self, value: bool):
		self._instance.InHoldStatusExternally = value
	@property
	def in_hold_status_by_command(self) -> bool:
		return self._instance.InHoldStatusByCommand
	@in_hold_status_by_command.setter
	def in_hold_status_by_command(self, value: bool):
		self._instance.InHoldStatusByCommand = value
	@property
	def alarming(self) -> bool:
		return self._instance.Alarming
	@alarming.setter
	def alarming(self, value: bool):
		self._instance.Alarming = value
	@property
	def error_occurring(self) -> bool:
		return self._instance.ErrorOccurring
	@error_occurring.setter
	def error_occurring(self, value: bool):
		self._instance.ErrorOccurring = value
	@property
	def servo_on(self) -> bool:
		return self._instance.ServoOn
	@servo_on.setter
	def servo_on(self, value: bool):
		self._instance.ServoOn = value
