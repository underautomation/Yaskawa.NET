import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotData as robot_data

class RobotData:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_data()
		else:
			self._instance = _internal
