import typing
from underautomation.yaskawa.high_speed_e_server.internal.high_speed_e_server_connect_parameters_base import HighSpeedEServerConnectParametersBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.Common import HighSpeedEServerConnectParameters as high_speed_e_server_connect_parameters

class HighSpeedEServerConnectParameters(HighSpeedEServerConnectParametersBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = high_speed_e_server_connect_parameters()
		else:
			self._instance = _internal
