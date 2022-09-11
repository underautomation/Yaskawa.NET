import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotManagementTimeData as robot_management_time_data

class RobotManagementTimeData(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_management_time_data()
		else:
			self._instance = _internal
	@property
	def start_time(self) -> str:
		return self._instance.StartTime
	@start_time.setter
	def start_time(self, value: str):
		self._instance.StartTime = value
	@property
	def ellapse_time(self) -> str:
		return self._instance.EllapseTime
	@ellapse_time.setter
	def ellapse_time(self, value: str):
		self._instance.EllapseTime = value
