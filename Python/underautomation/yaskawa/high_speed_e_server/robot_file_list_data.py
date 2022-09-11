import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
from underautomation.yaskawa.high_speed_e_server.robot_data_header import RobotDataHeader
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotFileListData as robot_file_list_data

class RobotFileListData(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_file_list_data()
		else:
			self._instance = _internal
	@property
	def headers(self) -> typing.Any:
		return self._instance.Headers
	@headers.setter
	def headers(self, value: typing.Any):
		self._instance.Headers = value
	@property
	def files(self) -> typing.List[str]:
		return self._instance.Files
	@files.setter
	def files(self, value: typing.List[str]):
		self._instance.Files = value
