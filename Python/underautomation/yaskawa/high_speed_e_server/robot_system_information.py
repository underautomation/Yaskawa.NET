import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotSystemInformation as robot_system_information

class RobotSystemInformation(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_system_information()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def software_version(self) -> str:
		return self._instance.SoftwareVersion
	@software_version.setter
	def software_version(self, value: str):
		self._instance.SoftwareVersion = value
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
	@property
	def parameter(self) -> str:
		return self._instance.Parameter
	@parameter.setter
	def parameter(self, value: str):
		self._instance.Parameter = value
