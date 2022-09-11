import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotPluralData as robot_plural_data_1

T = typing.TypeVar('T')
class RobotPluralData1(RobotData, typing.Generic[T]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_plural_data_1()
		else:
			self._instance = _internal
	@property
	def value(self) -> typing.Any:
		return self._instance.Value
	@value.setter
	def value(self, value: typing.Any):
		self._instance.Value = value
