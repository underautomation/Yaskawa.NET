import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer.Internal import HighSpeedEServerConnectParametersBase as high_speed_e_server_connect_parameters_base

class HighSpeedEServerConnectParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = high_speed_e_server_connect_parameters_base()
		else:
			self._instance = _internal
	@property
	def data_timeout_milliseconds(self) -> int:
		return self._instance.DataTimeoutMilliseconds
	@data_timeout_milliseconds.setter
	def data_timeout_milliseconds(self, value: int):
		self._instance.DataTimeoutMilliseconds = value
	@property
	def power_on_timeout_milliseconds(self) -> int:
		return self._instance.PowerOnTimeoutMilliseconds
	@power_on_timeout_milliseconds.setter
	def power_on_timeout_milliseconds(self, value: int):
		self._instance.PowerOnTimeoutMilliseconds = value
	@property
	def file_timeout_milliseconds(self) -> int:
		return self._instance.FileTimeoutMilliseconds
	@file_timeout_milliseconds.setter
	def file_timeout_milliseconds(self, value: int):
		self._instance.FileTimeoutMilliseconds = value
	@property
	def data_port(self) -> int:
		return self._instance.DataPort
	@data_port.setter
	def data_port(self, value: int):
		self._instance.DataPort = value
	@property
	def file_port(self) -> int:
		return self._instance.FilePort
	@file_port.setter
	def file_port(self, value: int):
		self._instance.FilePort = value
