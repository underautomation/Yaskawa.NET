import typing
from underautomation.yaskawa.high_speed_e_server.internal.high_speed_e_server_connect_parameters_base import HighSpeedEServerConnectParametersBase
from underautomation.yaskawa.high_speed_e_server.robot_alarm_data import RobotAlarmData
from underautomation.yaskawa.high_speed_e_server.robot_recent_alarm import RobotRecentAlarm
from underautomation.yaskawa.high_speed_e_server.robot_status_data import RobotStatusData
from underautomation.yaskawa.high_speed_e_server.robot_job_data import RobotJobData
from underautomation.yaskawa.high_speed_e_server.robot_axis_raw_data_1 import RobotAxisRawData1
from underautomation.yaskawa.high_speed_e_server.robot_control_group import RobotControlGroup
from underautomation.yaskawa.high_speed_e_server.robot_position_cartesian_data import RobotPositionCartesianData
from underautomation.yaskawa.high_speed_e_server.robot_position_data_1 import RobotPositionData1
from underautomation.yaskawa.high_speed_e_server.robot_data_header import RobotDataHeader
from underautomation.yaskawa.high_speed_e_server.alarm_reset_type import AlarmResetType
from underautomation.yaskawa.high_speed_e_server.on_off_command_type import OnOffCommandType
from underautomation.yaskawa.high_speed_e_server.switching_command import SwitchingCommand
from underautomation.yaskawa.high_speed_e_server.robot_management_time_data import RobotManagementTimeData
from underautomation.yaskawa.high_speed_e_server.management_time_type import ManagementTimeType
from underautomation.yaskawa.high_speed_e_server.robot_system_information import RobotSystemInformation
from underautomation.yaskawa.high_speed_e_server.robot_system_type_data import RobotSystemTypeData
from underautomation.yaskawa.high_speed_e_server.robot_plural_data_1 import RobotPluralData1
from underautomation.yaskawa.high_speed_e_server.robot_alarm_data_extended import RobotAlarmDataExtended
from underautomation.yaskawa.high_speed_e_server.position_command_classification import PositionCommandClassification
from underautomation.yaskawa.high_speed_e_server.position_command_operation_coordinate import PositionCommandOperationCoordinate
from underautomation.yaskawa.high_speed_e_server.robot_posture import RobotPosture
from underautomation.yaskawa.high_speed_e_server.position_command_type import PositionCommandType
from underautomation.yaskawa.high_speed_e_server.robot_file_list_data import RobotFileListData
from underautomation.yaskawa.high_speed_e_server.robot_file_content_data import RobotFileContentData
from underautomation.yaskawa.high_speed_e_server.robot_base_position_data import RobotBasePositionData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer.Internal import HighSpeedEServerClientBase as high_speed_e_server_client_base

class HighSpeedEServerClientBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = high_speed_e_server_client_base()
		else:
			self._instance = _internal
	def connect(self, ip: str, parameters: HighSpeedEServerConnectParametersBase) -> None:
		self._instance.Connect(ip, parameters._instance)
	def close(self) -> None:
		self._instance.Close()
	def get_alarm(self, alarm: RobotRecentAlarm) -> RobotAlarmData:
		return RobotAlarmData(self._instance.GetAlarm(alarm._instance))
	def get_status_information(self) -> RobotStatusData:
		return RobotStatusData(self._instance.GetStatusInformation())
	def get_executing_job_information(self) -> RobotJobData:
		return RobotJobData(self._instance.GetExecutingJobInformation())
	def get_configuration_information(self, type: RobotControlGroup) -> RobotAxisRawData1[str]:
		return RobotAxisRawData1[str](self._instance.GetConfigurationInformation(type._instance))
	def get_robot_cartesian_position(self) -> RobotPositionCartesianData:
		return RobotPositionCartesianData(self._instance.GetRobotCartesianPosition())
	def get_robot_joint_position(self) -> RobotPositionData1[int]:
		return RobotPositionData1[int](None, self._instance.GetRobotJointPosition())
	def get_robot_position(self, type: RobotControlGroup) -> RobotPositionData1[int]:
		return RobotPositionData1[int](None, self._instance.GetRobotPosition(type._instance))
	def get_position_error(self, type: RobotControlGroup) -> RobotPositionData1[int]:
		return RobotPositionData1[int](None, self._instance.GetPositionError(type._instance))
	def get_torque(self, type: RobotControlGroup) -> RobotPositionData1[int]:
		return RobotPositionData1[int](None, self._instance.GetTorque(type._instance))
	def alarm_reset(self, type: AlarmResetType) -> RobotDataHeader:
		return RobotDataHeader(self._instance.AlarmReset(type._instance))
	def servo_command(self, command: OnOffCommandType, value: bool) -> RobotDataHeader:
		return RobotDataHeader(self._instance.ServoCommand(command._instance, value))
	def switching_command(self, command: SwitchingCommand) -> RobotDataHeader:
		return RobotDataHeader(self._instance.SwitchingCommand(command._instance))
	def display(self, message: str) -> RobotDataHeader:
		return RobotDataHeader(self._instance.Display(message))
	def start_job(self) -> RobotDataHeader:
		return RobotDataHeader(self._instance.StartJob())
	def select_job(self, job: str, line: int) -> RobotDataHeader:
		return RobotDataHeader(self._instance.SelectJob(job, line))
	def get_management_time(self, type: ManagementTimeType, index: int=0) -> RobotManagementTimeData:
		return RobotManagementTimeData(self._instance.GetManagementTime(type._instance, index))
	def get_system_information(self, type: RobotSystemTypeData) -> RobotSystemInformation:
		return RobotSystemInformation(self._instance.GetSystemInformation(type._instance))
	def read_io(self, firstIndex: int, count: int) -> RobotPluralData1[int]:
		return RobotPluralData1[int](self._instance.ReadIO(firstIndex, count))
	def write_io(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteIO(firstIndex, data))
	def read_register(self, firstIndex: int, count: int) -> RobotPluralData1[int]:
		return RobotPluralData1[int](self._instance.ReadRegister(firstIndex, count))
	def write_register(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteRegister(firstIndex, data))
	def read_byte(self, firstIndex: int, count: int) -> RobotPluralData1[int]:
		return RobotPluralData1[int](self._instance.ReadByte(firstIndex, count))
	def write_byte(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteByte(firstIndex, data))
	def read_integer(self, firstIndex: int, count: int) -> RobotPluralData1[int]:
		return RobotPluralData1[int](self._instance.ReadInteger(firstIndex, count))
	def write_integer(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteInteger(firstIndex, data))
	def read_double(self, firstIndex: int, count: int) -> RobotPluralData1[float]:
		return RobotPluralData1[float](self._instance.ReadDouble(firstIndex, count))
	def write_double(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteDouble(firstIndex, data))
	def read_single(self, firstIndex: int, count: int) -> RobotPluralData1[float]:
		return RobotPluralData1[float](self._instance.ReadSingle(firstIndex, count))
	def write_single(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteSingle(firstIndex, data))
	def read16_bytes_char(self, firstIndex: int, count: int) -> RobotPluralData1[str]:
		return RobotPluralData1[str](self._instance.Read16BytesChar(firstIndex, count))
	def write16_bytes_char(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.Write16BytesChar(firstIndex, data))
	def read_position_variable(self, firstIndex: int, count: int) -> RobotPluralData1[RobotPositionData1[int]]:
		return RobotPluralData1[RobotPositionData1[int]](self._instance.ReadPositionVariable(firstIndex, count))
	def write_position_variable(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WritePositionVariable(firstIndex, data))
	def read_base_position(self, firstIndex: int, count: int) -> RobotPluralData1[RobotBasePositionData]:
		return RobotPluralData1[RobotBasePositionData](self._instance.ReadBasePosition(firstIndex, count))
	def write_base_position(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteBasePosition(firstIndex, data))
	def read_external_position(self, firstIndex: int, count: int) -> RobotPluralData1[RobotAxisRawData1[int]]:
		return RobotPluralData1[RobotAxisRawData1[int]](self._instance.ReadExternalPosition(firstIndex, count))
	def write_external_position(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.WriteExternalPosition(firstIndex, data))
	def get_alarm_extended(self, alarm: RobotRecentAlarm) -> RobotAlarmDataExtended:
		return RobotAlarmDataExtended(self._instance.GetAlarmExtended(alarm._instance))
	def move_cartesian(self, x: float, y: float, z: float, tx: float, ty: float, tz: float, classification: PositionCommandClassification, speed: float, coordinate: PositionCommandOperationCoordinate, posture: RobotPosture=None, commandtype: PositionCommandType=3, RobotControlGroup: int=1, StationControlGroup: int=0, tool: int=0, userCoordinate: int=0) -> RobotDataHeader:
		return RobotDataHeader(self._instance.MoveCartesian(x, y, z, tx, ty, tz, classification._instance, speed, coordinate._instance, posture._instance, commandtype._instance, RobotControlGroup, StationControlGroup, tool, userCoordinate))
	def move_joints(self, axesPulse: typing.List[int], classification: PositionCommandClassification, speed: float, commandtype: PositionCommandType=3, RobotControlGroup: int=1, StationControlGroup: int=1, tool: int=0) -> RobotDataHeader:
		return RobotDataHeader(self._instance.MoveJoints(axesPulse, classification._instance, speed, commandtype._instance, RobotControlGroup, StationControlGroup, tool))
	def read32_bytes_char(self, firstIndex: int, count: int) -> RobotPluralData1[str]:
		return RobotPluralData1[str](self._instance.Read32BytesChar(firstIndex, count))
	def write32_bytes_char(self, firstIndex: int, data: typing.Any) -> RobotDataHeader:
		return RobotDataHeader(self._instance.Write32BytesChar(firstIndex, data))
	def delete_file(self, name: str) -> RobotDataHeader:
		return RobotDataHeader(self._instance.DeleteFile(name))
	def load_file(self, name: str, content: str, onLoadFileProgress: typing.Any=None) -> typing.List[RobotDataHeader]:
		return [RobotDataHeader(x) for x in self._instance.LoadFile(name, content, onLoadFileProgress)]
	def get_file_list(self, pattern: str) -> RobotFileListData:
		return RobotFileListData(self._instance.GetFileList(pattern))
	def get_file(self, name: str, onGetFileProgress: typing.Any=None) -> RobotFileContentData:
		return RobotFileContentData(self._instance.GetFile(name, onGetFileProgress))
	@property
	def ip(self) -> str:
		return self._instance.IP
	@property
	def connected(self) -> bool:
		return self._instance.Connected
