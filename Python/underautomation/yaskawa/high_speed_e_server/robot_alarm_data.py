import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotAlarmData as robot_alarm_data

class RobotAlarmData(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_alarm_data()
		else:
			self._instance = _internal
	@property
	def code(self) -> int:
		return self._instance.Code
	@code.setter
	def code(self, value: int):
		self._instance.Code = value
	@property
	def data(self) -> int:
		return self._instance.Data
	@data.setter
	def data(self, value: int):
		self._instance.Data = value
	@property
	def type(self) -> int:
		return self._instance.Type
	@type.setter
	def type(self, value: int):
		self._instance.Type = value
	@property
	def occurring_time(self) -> str:
		return self._instance.OccurringTime
	@occurring_time.setter
	def occurring_time(self, value: str):
		self._instance.OccurringTime = value
	@property
	def text(self) -> str:
		return self._instance.Text
	@text.setter
	def text(self, value: str):
		self._instance.Text = value
