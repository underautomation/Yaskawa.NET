import typing
from underautomation.yaskawa.high_speed_e_server.robot_data_header import RobotDataHeader
from underautomation.yaskawa.high_speed_e_server.robot_posture import RobotPosture
from underautomation.yaskawa.high_speed_e_server.robot_position_data_type import RobotPositionDataType
from underautomation.yaskawa.high_speed_e_server.robot_axis_raw_data_1 import RobotAxisRawData1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotPositionData as robot_position_data_1

t = typing.TypeVar('t')
class RobotPositionData1(RobotAxisRawData1[t], typing.Generic[t]):
	def __init__(self, header: RobotDataHeader, _internal = 0):
		if(_internal == 0):
			self._instance = robot_position_data_1(header)
		else:
			self._instance = _internal
	@property
	def form(self) -> RobotPosture:
		return RobotPosture(None, None, self._instance.Form)
	@form.setter
	def form(self, value: RobotPosture):
		self._instance.Form = value
	@property
	def data_type(self) -> RobotPositionDataType:
		return RobotPositionDataType(self._instance.DataType)
	@data_type.setter
	def data_type(self, value: RobotPositionDataType):
		self._instance.DataType = value
	@property
	def tool_number(self) -> int:
		return self._instance.ToolNumber
	@tool_number.setter
	def tool_number(self, value: int):
		self._instance.ToolNumber = value
	@property
	def user_coordinate_number(self) -> int:
		return self._instance.UserCoordinateNumber
	@user_coordinate_number.setter
	def user_coordinate_number(self, value: int):
		self._instance.UserCoordinateNumber = value
