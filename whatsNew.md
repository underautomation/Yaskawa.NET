### HSES: I/O Group Addressing

- **New `IOType` enum**: strongly-typed enumeration of all Yaskawa I/O signal categories (`GeneralInput`, `GeneralOutput`, `ExternalInput`, `NetworkInput`, `ExternalOutput`, `NetworkOutput`, `SpecificInput`, `SpecificOutput`, `InterfacePanelInput`, `AuxiliaryRelay`, `RobotControlStatus`, `PseudoInput`).
- **New `IoHelpers` static class**: utility for converting an I/O type + 1-based group number + bit index into a flat Yaskawa 5-digit contact number (`ConvertIOGroupToBitAddress`).
- **New `ReadIO(IOType, group, count)`** overload: reads multiple I/O bytes using group addressing instead of a raw flat index.
- **New `WriteIO(IOType, group, data)`** overload: writes I/O bytes using group addressing.
- **New `WriteIoNetworkInput(group, data)`** convenience method: shorthand for writing bytes to the Network Input group.

### HSES: Job Call Stack

- New `GetJobStack(taskNumber)` command returns the call stack (job name, line number, step number) of a running task, useful for debugging multi-level job execution.

### HSES Improvements

- **Simplified connection**: `Connect()` method now accepts optional parameters with defaults instead of requiring a parameters object.
- **Public constants** for default connection values: `DEFAULT_DATA_TIMEOUT_MILLISECONDS`, `DEFAULT_POWER_ON_TIMEOUT_MILLISECONDS`, `DEFAULT_FILE_TIMEOUT_MILLISECONDS`, `DEFAULT_DATA_PORT`, `DEFAULT_FILE_PORT`.
- **New strongly-typed data classes** for robot responses: `RobotIOData`, `RobotByteData`, `RobotIntegerData`, `RobotDoubleData`, `RobotRealData`, `RobotStringData`, `RobotPositionData`, `RobotBasePositionData`, `RobotRegisterData`.
- **Read-only properties**: All data classes returned by the robot (`RobotStatusData`, `RobotAlarmData`, `RobotJobData`, `RobotPositionCartesianData`, `RobotSystemInformation`, etc.) now have read-only properties for safer API usage.
- `GetFileProgress` and `LoadFileProgress` now use read-only properties instead of public fields.
- Improved `RobotPositionData` and `FlipInformation` for more robust data handling and encoding.
- Default optional argument value for move commands are now `int RobotControlGroup = 1, int StationControlGroup = 0` to work without specifying control groups in most cases.
- **`RobotPosture` enhancements**: added `ToString()`, `Equals(object)`, and `GetHashCode()` overrides for easier debugging, logging, and value comparisons.
- **Speed override precision fix**: `RobotJobData.SpeedOverride` is now a `double` and the HSES parser converts the controller raw value to a percentage scale.

### Improvements

- **`ConnectException`**: new strongly-typed exception thrown when a connection to the robot controller fails (replaces generic exceptions).
- **`YaskawaRobot.Connected`** property: returns `true` if any communication interface is currently connected.
- **New `RobotFileContentData.ContentRaw` property**: complements `Content` by exposing the raw downloaded bytes, which is useful for binary files such as `CMOS.BIN`.
- **Bug fix**: fixed incorrect reading of `Double` variables — `Double` maps to a 32-bit double-integer (DINT), not a floating-point `double`.

### Internal migration to new C# version

- The entire library has been rewritten for improved performance, tooling compatibility, and modern language feature support.

### Documentation

- Added XML documentation to all public classes, methods, and properties.
- Improved IntelliSense support with detailed parameter descriptions.

### Internal

- Refactored internal codebase to improve maintainability.
- `HighSpeedEServerConnectParametersBase` is now abstract.
- Added safe read methods to Packet Reader for more robust protocol parsing.
- Updated embedded submodule reference for `Yaskawa.py`.
