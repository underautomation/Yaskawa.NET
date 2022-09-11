import typing
from underautomation.yaskawa.connect_parameters import ConnectParameters
from underautomation.yaskawa.high_speed_e_server.internal.high_speed_e_server_client_internal import HighSpeedEServerClientInternal
from underautomation.yaskawa.license.license_info import LicenseInfo
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__),  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa import YaskawaRobot as yaskawa_robot

class YaskawaRobot:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = yaskawa_robot()
		else:
			self._instance = _internal
	def connect(self, parameters: ConnectParameters) -> None:
		self._instance.Connect(parameters._instance)
	@staticmethod
	def register_license(Licensee: str, key: str) -> LicenseInfo:
		return yaskawa_robot.RegisterLicense(Licensee, key)
	@property
	def high_speed_e_server(self) -> HighSpeedEServerClientInternal:
		return HighSpeedEServerClientInternal(self._instance.HighSpeedEServer)
	@property
	def license_info(self) -> LicenseInfo:
		return LicenseInfo(None, None, self._instance.LicenseInfo)
