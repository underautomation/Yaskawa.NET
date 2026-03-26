## Fixed Enum Tool / User Coordinates

- Corrected swapped enum values for tool/user coordinate modes in High Speed Ethernet Server position data.
- `PositionCommandOperationCoordinate.Tool` is now value `18` (TCP/tool frame).
- `PositionCommandOperationCoordinate.User` is now value `19` (user-defined frame).
- `RobotPositionDataType.ToolCoordinateValue` and `RobotPositionDataType.UserCoordinateValue` were aligned accordingly.
