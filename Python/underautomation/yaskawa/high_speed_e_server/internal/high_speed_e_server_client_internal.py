import typing
from underautomation.yaskawa.high_speed_e_server.internal.high_speed_e_server_client_base import HighSpeedEServerClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer.Internal import HighSpeedEServerClientInternal as high_speed_e_server_client_internal

class HighSpeedEServerClientInternal(HighSpeedEServerClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = high_speed_e_server_client_internal()
		else:
			self._instance = _internal
