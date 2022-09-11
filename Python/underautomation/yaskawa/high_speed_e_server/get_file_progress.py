import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.Yaskawa.dll')))
from UnderAutomation.Yaskawa.HighSpeedEServer import GetFileProgress as get_file_progress

class GetFileProgress:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = get_file_progress()
		else:
			self._instance = _internal
	@property
	def completed(self) -> bool:
		return self._instance.Completed
	@completed.setter
	def completed(self, value: bool):
		self._instance.Completed = value
	@property
	def file_name(self) -> str:
		return self._instance.FileName
	@file_name.setter
	def file_name(self, value: str):
		self._instance.FileName = value
	@property
	def downloaded_bytes(self) -> int:
		return self._instance.DownloadedBytes
	@downloaded_bytes.setter
	def downloaded_bytes(self, value: int):
		self._instance.DownloadedBytes = value
