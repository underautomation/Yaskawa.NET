import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotJobData as robot_job_data

class RobotJobData(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_job_data()
		else:
			self._instance = _internal
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
	@property
	def line(self) -> int:
		return self._instance.Line
	@line.setter
	def line(self, value: int):
		self._instance.Line = value
	@property
	def step(self) -> int:
		return self._instance.Step
	@step.setter
	def step(self, value: int):
		self._instance.Step = value
	@property
	def speed_override(self) -> int:
		return self._instance.SpeedOverride
	@speed_override.setter
	def speed_override(self, value: int):
		self._instance.SpeedOverride = value
