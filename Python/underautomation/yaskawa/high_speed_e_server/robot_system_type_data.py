import typing
from underautomation.yaskawa.high_speed_e_server.robot_system_type import RobotSystemType
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotSystemTypeData as robot_system_type_data

class RobotSystemTypeData:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_system_type_data()
		else:
			self._instance = _internal
	@property
	def default(self) -> 'RobotSystemTypeData':
		return RobotSystemTypeData(self._instance.Default)
	@property
	def index(self) -> int:
		return self._instance.Index
	@property
	def type(self) -> RobotSystemType:
		return RobotSystemType(self._instance.type)
	@property
	def byte(self) -> int:
		return self._instance.Byte
