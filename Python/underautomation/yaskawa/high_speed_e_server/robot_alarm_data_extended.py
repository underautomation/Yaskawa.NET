import typing
from underautomation.yaskawa.high_speed_e_server.robot_alarm_data import RobotAlarmData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotAlarmDataExtended as robot_alarm_data_extended

class RobotAlarmDataExtended(RobotAlarmData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_alarm_data_extended()
		else:
			self._instance = _internal
	@property
	def additionnal_information(self) -> str:
		return self._instance.AdditionnalInformation
	@additionnal_information.setter
	def additionnal_information(self, value: str):
		self._instance.AdditionnalInformation = value
	@property
	def sub_data(self) -> str:
		return self._instance.SubData
	@sub_data.setter
	def sub_data(self, value: str):
		self._instance.SubData = value
	@property
	def sub_data_reverse(self) -> str:
		return self._instance.SubDataReverse
	@sub_data_reverse.setter
	def sub_data_reverse(self, value: str):
		self._instance.SubDataReverse = value
