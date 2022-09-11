import typing
from underautomation.yaskawa.high_speed_e_server.control_group import ControlGroup
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotControlGroup as robot_control_group

class RobotControlGroup:
	def __init__(self, group: ControlGroup, index: int, _internal = 0):
		if(_internal == 0):
			self._instance = robot_control_group(group, index)
		else:
			self._instance = _internal
	@property
	def default_robot_cartesian(self) -> 'RobotControlGroup':
		return RobotControlGroup(None, None, self._instance.DefaultRobotCartesian)
	@property
	def default_robot_pulse(self) -> 'RobotControlGroup':
		return RobotControlGroup(None, None, self._instance.DefaultRobotPulse)
	@property
	def group(self) -> ControlGroup:
		return ControlGroup(self._instance.Group)
	@property
	def index(self) -> int:
		return self._instance.Index
	@property
	def byte_value(self) -> int:
		return self._instance.ByteValue
