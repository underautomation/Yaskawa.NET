## Ethernet Server

`robot.EServer` reads and commands the controller through its Ethernet Server, over TCP (port 80), next to the High Speed Ethernet Server. It reads the status, the alarms with their text, the positions in the base, robot, user or tool frame, the torque and the encoder temperatures. It switches the servo, holds the robot, selects the cycle and the mode, lists, selects and starts the jobs, waits for the end of a job in one call, moves the robot, and reads and writes the B, I, D, R and S variables and the I/O. Commands that the controller refuses throw a `HostControlException`.

```csharp
var parameters = new ConnectParameters("192.168.0.1");
parameters.EServer.Enable = true;

var robot = new YaskawaRobot();
robot.Connect(parameters);

robot.EServer.SelectJob("PICK", 0);
robot.EServer.SetServo(true);
robot.EServer.StartJob();
bool completed = robot.EServer.WaitForJobCompletion(60);
```

`EServerClient` is the standalone client.

## FTP

`robot.Ftp` transfers files with the FTP server of the controller (port 21): list the folders, download and upload text, bytes, local files or several files at once, test and delete files, with a progress callback. Every method has an async version. `FtpConnectParameters` sets the account (`anonymous`, `ftp` or `rcmaster`). Each failure throws an `FtpException` with the reason (`AccessDenied`, `JobAlreadyExists`...). `FtpClient` is the standalone client. The FTP client is based on FluentFTP 39.4.0 (MIT), listed in `THIRD-PARTY-NOTICES.txt`.

```csharp
var parameters = new ConnectParameters("192.168.0.1");
parameters.Ftp.Enable = true;
parameters.Ftp.FtpUser = "ftp";

var robot = new YaskawaRobot();
robot.Connect(parameters);

robot.Ftp.DownloadFilesToLocal(new[] { "/JOB/TEST.JBI", "/DAT/VAR.DAT" }, @"C:\Backup");
robot.Ftp.UploadFileFromLocal(@"C:\Jobs\PICK.JBI");
```

On a YRC1000micro, FTP downloads `ALL.PRM` (1.4 MB) in about 13 s, against about 45 s with the High Speed Ethernet Server.

## HTTP

`robot.Http` reads the web server of the controller (port 80): `GetFileList(FileExtension.DAT)` lists the files of a type with their description, `GetFile("TEST.JBI")` returns the text of a file. No account and no remote mode are needed. `HttpClient` is the standalone client.

## Offline kinematics

`KinematicsUtils.ForwardKinematics` computes the flange position from joint angles in degrees, and `KinematicsUtils.InverseKinematics` returns every joint solution for a position: up to 8 for the arms with a spherical wrist, up to 16 for the cobots with a wrist offset (HC10, HC10DT, HC20SDT...). The geometry is a `DhParameters`: from the catalog of 169 models (`ArmKinematicModels`), from the `ALL.PRM` file of a controller (`DhParameters.FromPrmFile`, `FromPrmContent`), or from your own values. The computation runs on the PC, without a controller.

```csharp
DhParameters dh = DhParameters.FromArmKinematicModel(ArmKinematicModels.GP7);
CartesianPosition flange = KinematicsUtils.ForwardKinematics(new JointsAngles(0, 0, 0, 0, -90, 0), dh);
JointsAngles[] solutions = KinematicsUtils.InverseKinematics(new CartesianPosition(400, 100, 300, 180, 0, 0), dh);
```

## Common interfaces

The High Speed Ethernet Server and the Ethernet Server clients implement the same interfaces of `UnderAutomation.Yaskawa.Common`: `IRobotClient` groups `IStatusReader`, `IPositionReader`, `IAlarmReader`, `IRobotControl`, `IIOAccess`, `IVariableAccess`, `ITorqueReader` and `IMotionControl`. A method that takes an `IRobotClient` works with both protocols. The file clients implement `IFileReader` and `IFileManager`.

## Servo, hold and cycle

`robot.HighSpeedEServer` has `SetServo(bool)`, `SetHold(bool)`, `SetTeachPendantLockState(bool)` and `SetCycle(RobotCycleType)`, with the same names as the Ethernet Server. `ServoCommand` and `SwitchingCommand` still work and are marked obsolete. Replace `ServoCommand(OnOffCommandType.Servo, true)` by `SetServo(true)`, and `SwitchingCommand(SwitchingCommands.Cycle)` by `SetCycle(RobotCycleType.OneCycle)`.

## Position variables

`ReadPositionVariable`, `ReadBasePosition` and `ReadExternalPosition` set `IsDefined` to `false` for a variable that was never taught. `RobotPositionIntData.ToCartesian()` converts a Cartesian position variable to mm and degrees.

## .NET 10

The NuGet package and `UnderAutomation.Yaskawa.zip` now contain a `net10.0` build. The package targets .NET Framework 3.5 to 4.8, .NET Standard 2.0 and 2.1, .NET Core 3.0, and .NET 5, 6, 8, 9 and 10.

## Package information

The NuGet package links to the Yaskawa page of underautomation.com, to the `Yaskawa.NET` repository and to its release notes. Its description and tags are updated.

## Fixes

- `RobotControlGroup(ControlGroup.StationPulseValue, 1)` now reads the first station. Before, the index `n` read the station `n + 1`. The index of a station goes from 1 to 24.
- `GetManagementTime(ManagementTimeType.MotionTimeS1ToS24, n)` now reads the motion time of the station `n`. Before, it read the station `n + 1`.
- `GetConfigurationInformation()` now returns the names of the axes. Before, it sent the wrong request to the controller.
- The progress of `LoadFile` now ends at the size of the file: `LoadedBytes` is the number of bytes sent, including the last block.
- The documentation of `ManagementTimeType` gives the right index: 1 to 8 for the robots, 1 to 24 for the stations.
