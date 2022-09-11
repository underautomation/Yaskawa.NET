import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotDataHeader as robot_data_header

class RobotDataHeader:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_data_header()
		else:
			self._instance = _internal
	@property
	def ip(self) -> typing.Any:
		return self._instance.IP
	@ip.setter
	def ip(self, value: typing.Any):
		self._instance.IP = value
	@property
	def data_size(self) -> int:
		return self._instance.DataSize
	@data_size.setter
	def data_size(self, value: int):
		self._instance.DataSize = value
	@property
	def block_no(self) -> int:
		return self._instance.BlockNo
	@block_no.setter
	def block_no(self, value: int):
		self._instance.BlockNo = value
	@property
	def is_last_block(self) -> bool:
		return self._instance.IsLastBlock
