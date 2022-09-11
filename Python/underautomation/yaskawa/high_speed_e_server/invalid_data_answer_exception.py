import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import InvalidDataAnswerException as invalid_data_answer_exception

class InvalidDataAnswerException:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = invalid_data_answer_exception()
		else:
			self._instance = _internal
	@property
	def status(self) -> int:
		return self._instance.Status
	@status.setter
	def status(self, value: int):
		self._instance.Status = value
	@property
	def added_status(self) -> int:
		return self._instance.AddedStatus
	@added_status.setter
	def added_status(self, value: int):
		self._instance.AddedStatus = value
