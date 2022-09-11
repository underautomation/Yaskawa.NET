import typing
from underautomation.yaskawa.high_speed_e_server.robot_data import RobotData
from underautomation.yaskawa.high_speed_e_server.robot_data_header import RobotDataHeader
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotFileContentData as robot_file_content_data

class RobotFileContentData(RobotData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_file_content_data()
		else:
			self._instance = _internal
	def get_param(self, section: str, parameterLine: int, parameterColumn: int) -> int:
		return self._instance.GetParam(section, parameterLine, parameterColumn)
	@property
	def headers(self) -> typing.Any:
		return self._instance.Headers
	@headers.setter
	def headers(self, value: typing.Any):
		self._instance.Headers = value
	@property
	def content(self) -> str:
		return self._instance.Content
	@content.setter
	def content(self, value: str):
		self._instance.Content = value
	@property
	def file_name(self) -> str:
		return self._instance.FileName
	@file_name.setter
	def file_name(self, value: str):
		self._instance.FileName = value
