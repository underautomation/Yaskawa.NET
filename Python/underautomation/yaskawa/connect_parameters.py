import typing
from underautomation.yaskawa.common.high_speed_e_server_connect_parameters import HighSpeedEServerConnectParameters
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__),  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa import ConnectParameters as connect_parameters

class ConnectParameters:
	def __init__(self, ip: str, _internal = 0):
		if(_internal == 0):
			self._instance = connect_parameters(ip)
		else:
			self._instance = _internal
	@property
	def ping_before_connect(self) -> bool:
		return self._instance.PingBeforeConnect
	@ping_before_connect.setter
	def ping_before_connect(self, value: bool):
		self._instance.PingBeforeConnect = value
	@property
	def ip(self) -> str:
		return self._instance.IP
	@ip.setter
	def ip(self, value: str):
		self._instance.IP = value
	@property
	def high_speed_e_server(self) -> HighSpeedEServerConnectParameters:
		return HighSpeedEServerConnectParameters(self._instance.HighSpeedEServer)
	@high_speed_e_server.setter
	def high_speed_e_server(self, value: HighSpeedEServerConnectParameters):
		self._instance.HighSpeedEServer = value
