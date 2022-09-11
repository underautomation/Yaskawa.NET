import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotAxisRawData as robot_axis_raw_data_1

T = typing.TypeVar('T')
class RobotAxisRawData1(RobotData, typing.Generic[T]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_axis_raw_data_1()
		else:
			self._instance = _internal
	@property
	def axes(self) -> typing.Any:
		return self._instance.Axes
	@property
	def axis1(self) -> T:
		return self._instance.Axis1
	@axis1.setter
	def axis1(self, value: T):
		self._instance.Axis1 = value
	@property
	def axis2(self) -> T:
		return self._instance.Axis2
	@axis2.setter
	def axis2(self, value: T):
		self._instance.Axis2 = value
	@property
	def axis3(self) -> T:
		return self._instance.Axis3
	@axis3.setter
	def axis3(self, value: T):
		self._instance.Axis3 = value
	@property
	def axis4(self) -> T:
		return self._instance.Axis4
	@axis4.setter
	def axis4(self, value: T):
		self._instance.Axis4 = value
	@property
	def axis5(self) -> T:
		return self._instance.Axis5
	@axis5.setter
	def axis5(self, value: T):
		self._instance.Axis5 = value
	@property
	def axis6(self) -> T:
		return self._instance.Axis6
	@axis6.setter
	def axis6(self, value: T):
		self._instance.Axis6 = value
