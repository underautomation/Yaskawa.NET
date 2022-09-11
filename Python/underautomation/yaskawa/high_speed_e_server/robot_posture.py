import typing
from underautomation.yaskawa.high_speed_e_server.orientation_flip_information import OrientationFlipInformation
from underautomation.yaskawa.high_speed_e_server.arm_flip_information import ArmFlipInformation
from underautomation.yaskawa.high_speed_e_server.flip_no_flip_information import FlipNoFlipInformation
from underautomation.yaskawa.high_speed_e_server.axis_flip_information import AxisFlipInformation
from underautomation.yaskawa.high_speed_e_server.regarded_reverse_position_specified import RegardedReversePositionSpecified
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import RobotPosture as robot_posture

class RobotPosture:
	def __init__(self, form: int, extendedForm: int, _internal = 0):
		if(_internal == 0):
			self._instance = robot_posture(form, extendedForm)
		else:
			self._instance = _internal
	def to_integer(self) -> int:
		return self._instance.ToInteger()
	@staticmethod
	def from_integer(value: int) -> 'RobotPosture':
		return robot_posture.FromInteger(value)
	@property
	def form(self) -> int:
		return self._instance.Form
	@form.setter
	def form(self, value: int):
		self._instance.Form = value
	@property
	def extended_form(self) -> int:
		return self._instance.ExtendedForm
	@extended_form.setter
	def extended_form(self, value: int):
		self._instance.ExtendedForm = value
	@property
	def orientation(self) -> OrientationFlipInformation:
		return OrientationFlipInformation(self._instance.Orientation)
	@property
	def arm(self) -> ArmFlipInformation:
		return ArmFlipInformation(self._instance.Arm)
	@property
	def flip(self) -> FlipNoFlipInformation:
		return FlipNoFlipInformation(self._instance.Flip)
	@property
	def r_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.RAxis)
	@property
	def t_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.TAxis)
	@property
	def s_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.SAxis)
	@property
	def redundant(self) -> OrientationFlipInformation:
		return OrientationFlipInformation(self._instance.Redundant)
	@property
	def regarded_reverse_position_specified(self) -> RegardedReversePositionSpecified:
		return RegardedReversePositionSpecified(self._instance.RegardedReversePositionSpecified)
	@property
	def l_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.LAxis)
	@property
	def u_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.UAxis)
	@property
	def b_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.BAxis)
	@property
	def e_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.EAxis)
	@property
	def w_axis(self) -> AxisFlipInformation:
		return AxisFlipInformation(self._instance.WAxis)
	@property
	def default(self) -> 'RobotPosture':
		return RobotPosture(None, None, self._instance.Default)
