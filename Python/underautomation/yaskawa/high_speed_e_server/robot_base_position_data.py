import typing
from underautomation.yaskawa.high_speed_e_server.robot_base_position_type import RobotBasePositionType
from underautomation.yaskawa.high_speed_e_server.robot_data_header import RobotDataHeader
from underautomation.yaskawa.high_speed_e_server.robot_axis_raw_data_1 import RobotAxisRawData1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotBasePositionData as robot_base_position_data

class RobotBasePositionData(RobotAxisRawData1[int]):
	def __init__(self, header: RobotDataHeader, _internal = 0):
		if(_internal == 0):
			self._instance = robot_base_position_data(header)
		else:
			self._instance = _internal
	@property
	def data_type(self) -> RobotBasePositionType:
		return RobotBasePositionType(self._instance.DataType)
	@data_type.setter
	def data_type(self, value: RobotBasePositionType):
		self._instance.DataType = value
