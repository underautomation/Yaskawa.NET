# Yaskawa Robot Communication SDK for .NET

[![UnderAutomation Yaskawa communication SDK](https://raw.githubusercontent.com/underautomation/Yaskawa.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com/yaskawa)

[![NuGet](https://img.shields.io/nuget/v/UnderAutomation.Yaskawa?label=NuGet&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.Yaskawa/)
[![NuGet downloads](https://img.shields.io/nuget/dt/UnderAutomation.Yaskawa?label=Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.Yaskawa/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#compatibility)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0_2.1-blueviolet)](#compatibility)
[![.NET](https://img.shields.io/badge/.NET-5_to_10-blueviolet)](#compatibility)
[![License](https://img.shields.io/badge/license-commercial-blue)](https://underautomation.com/yaskawa/eula)

**UnderAutomation.Yaskawa** is a fully managed .NET SDK that communicates with Yaskawa Motoman robot
controllers (**YRC1000 (micro)**, **MOTOMAN NEXT**, **DX100 / DX200**, **FS100**, **ERC / XRC / MRC**) through the **High Speed Ethernet Server** (HSES)
of the controller, over UDP. Nothing is installed on the controller, no Yaskawa option is needed.

Use it to read the status, the alarms and the positions, move the robot, select and start jobs, read and
write variables and I/O, and transfer files, from a normal .NET application.

- Product page: [underautomation.com/yaskawa](https://underautomation.com/yaskawa)
- Documentation: [underautomation.com/yaskawa/documentation](https://underautomation.com/yaskawa/documentation)
- Also available for Python: [Yaskawa.py](https://github.com/underautomation/Yaskawa.py), and LabVIEW: [Yaskawa.vi](https://github.com/underautomation/Yaskawa.vi).

## What you can do

- **Status and alarms:** read the status of the controller (mode, servo, hold, alarm), read the last
  alarms, reset the alarms.
- **Positions:** read the Cartesian position, the joint position in pulses, the position error and the
  torque of each axis.
- **Motion:** servo on and off, Cartesian moves and joint moves, with a speed and a coordinate system.
- **Jobs:** select and start a job, read the executing job and the job stack.
- **Variables:** read and write registers, byte, integer, double integer, real and string variables,
  position variables, base and external axis positions.
- **Inputs / Outputs:** read and write the I/O signals by address or by type and group.
- **Files:** list, download, upload and delete files, with a progress callback.
- **System:** system information, management times (operating, servo and playback time), system
  parameters, message on the pendant.

The High Speed Ethernet Server uses the UDP ports 10040 (data) and 10041 (files) by default.

## Example application

A Windows Forms application shows the features of the SDK. Its source code is in this repository, in
[`UnderAutomation.Yaskawa.Showcase.Forms`](UnderAutomation.Yaskawa.Showcase.Forms).

**Download:** [UnderAutomation.Yaskawa.Showcase.Forms.exe](https://github.com/underautomation/Yaskawa.NET/releases/latest/download/UnderAutomation.Yaskawa.Showcase.Forms.exe) ([all releases](https://github.com/underautomation/Yaskawa.NET/releases))

## Installation

```bash
dotnet add package UnderAutomation.Yaskawa
```

Or with the NuGet Package Manager console:

```
Install-Package UnderAutomation.Yaskawa
```

You can also download [UnderAutomation.Yaskawa.zip](https://github.com/underautomation/Yaskawa.NET/releases/latest/download/UnderAutomation.Yaskawa.zip)
from the [releases page](https://github.com/underautomation/Yaskawa.NET/releases). It contains one folder
per target framework. On Windows, unblock the zip file before you extract it (right-click, "Properties",
"Unblock"), then reference the DLL of your framework.

## Getting started

```csharp
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

// The SDK runs in trial mode for 30 days. Register your key to remove the trial limit.
YaskawaRobot.RegisterLicense("Your Company", "your-license-key");

var robot = new YaskawaRobot();
robot.Connect("192.168.0.1");

RobotStatusData status = robot.HighSpeedEServer.GetStatusInformation();
Console.WriteLine($"Servo on: {status.ServoOn}, alarm: {status.Alarming}");

robot.Disconnect();
```

To change the ports or the timeouts, use `ConnectParameters`:

```csharp
var parameters = new ConnectParameters("192.168.0.1");
parameters.PingBeforeConnect = true;                         // default
parameters.HighSpeedEServer.DataPort = 10040;                // default
parameters.HighSpeedEServer.DataTimeoutMilliseconds = 1500;  // default
robot.Connect(parameters);
```

## Features

Everything is reached through `robot.HighSpeedEServer`.

### Status and alarms

```csharp
RobotStatusData status = robot.HighSpeedEServer.GetStatusInformation();
Console.WriteLine($"Teach: {status.Teach}, Play: {status.Play}, Running: {status.Running}");

RobotAlarmData alarm = robot.HighSpeedEServer.GetAlarm(RobotRecentAlarm.Latest);
Console.WriteLine($"{alarm.Code} {alarm.Text} ({alarm.OccurringTime})");

robot.HighSpeedEServer.AlarmReset(AlarmResetType.Reset);
```

### Positions

```csharp
RobotPositionCartesianData position = robot.HighSpeedEServer.GetRobotCartesianPosition();
Console.WriteLine($"X={position.X} Y={position.Y} Z={position.Z} Rx={position.Rx} Ry={position.Ry} Rz={position.Rz}");

// Pulses of each axis
RobotPositionIntData joints = robot.HighSpeedEServer.GetRobotJointPosition();
Console.WriteLine(string.Join(", ", joints.Axes));

RobotAxisIntData error = robot.HighSpeedEServer.GetPositionError();
RobotAxisIntData torque = robot.HighSpeedEServer.GetTorque();
```

### Motion

The robot must be in remote mode, see "Configure the robot" below.

```csharp
robot.HighSpeedEServer.ServoCommand(OnOffCommandType.Servo, true);

// Cartesian move: mm and degrees, speed in mm/s, in the robot coordinate system
robot.HighSpeedEServer.MoveCartesian(
    x: 1000, y: 10, z: 0, rx: 0, ry: 0, rz: 0,
    PositionCommandClassification.Cartesian_MM_S,
    speed: 10,
    PositionCommandOperationCoordinate.Robot);

// Joint move: pulses of each axis, speed in % of the maximum speed
robot.HighSpeedEServer.MoveJoints(new int[] { 1000, 0, 0, 0, 0, 0 }, PositionCommandClassification.LinkPercent, 10);
```

Optional parameters of `MoveCartesian` and `MoveJoints`: command type (`LinkAbsolute`,
`StraightAbsolute`, `StraightIncrement`), posture, control groups, tool and user coordinate numbers.

### Jobs

```csharp
robot.HighSpeedEServer.SelectJob("PROGRAM", line: 0);
robot.HighSpeedEServer.StartJob();

RobotJobData job = robot.HighSpeedEServer.GetExecutingJobInformation();
Console.WriteLine($"{job.Name} line {job.Line}, step {job.Step}");
```

### Variables

Each read method takes the first index and the number of values, and returns an object with a `Value`
array. Each write method takes the first index and an array.

```csharp
RobotRegisterData registers = robot.HighSpeedEServer.ReadRegister(firstIndex: 0, count: 5);
robot.HighSpeedEServer.WriteRegister(0, new short[] { 100, 200 });

RobotByteVariableData bytes = robot.HighSpeedEServer.ReadByte(0, 4);
RobotIntegerVariableData integers = robot.HighSpeedEServer.ReadInteger(0, 4);
RobotDoubleIntegerVariableData doubleIntegers = robot.HighSpeedEServer.ReadDoubleInteger(0, 4);
RobotRealVariableData reals = robot.HighSpeedEServer.ReadReal(0, 4);
RobotStringVariableData strings = robot.HighSpeedEServer.Read16BytesChar(0, 2);
RobotStringVariableData longStrings = robot.HighSpeedEServer.Read32BytesChar(0, 2);

RobotPositionVariableData positions = robot.HighSpeedEServer.ReadPositionVariable(1, 4);
RobotBasePositionVariableData basePositions = robot.HighSpeedEServer.ReadBasePosition(0, 1);
RobotExternalAxisVariableData externalPositions = robot.HighSpeedEServer.ReadExternalPosition(0, 1);
```

### Inputs / Outputs

The first index selects the signal area, for example 1 to 512 for the robot user inputs, 1001 to 1512
for the robot user outputs, 2701 to 2956 for the network inputs. Each index is one byte of 8 signals. The
number of bytes is even: `ReadIO` rounds it up, `WriteIO` needs an even length.

```csharp
RobotIOData outputs = robot.HighSpeedEServer.ReadIO(firstIndex: 1001, count: 4);
Console.WriteLine(BitConverter.ToString(outputs.Value));

robot.HighSpeedEServer.WriteIO(2701, new byte[] { 1, 0 });

// Or by type and group
RobotIOData inputs = robot.HighSpeedEServer.ReadIO(IOType.GeneralInput, 1, 2);
```

### Files

```csharp
string[] files = robot.HighSpeedEServer.GetFileList("*.JBI").Files;

robot.HighSpeedEServer.LoadFile("PROGRAM.JBI", File.ReadAllText("PROGRAM.JBI"),
    progress => Console.WriteLine($"{progress.LoadedBytes} / {progress.TotalBytes}"));

RobotFileContentData file = robot.HighSpeedEServer.GetFile("PROGRAM.JBI");
Console.WriteLine(file.Content);

robot.HighSpeedEServer.DeleteFile("PROGRAM.JBI");
```

### System

```csharp
RobotSystemInformation system = robot.HighSpeedEServer.GetSystemInformation();
Console.WriteLine($"{system.Name} {system.SoftwareVersion}");

RobotManagementTimeData servoTime = robot.HighSpeedEServer.GetManagementTime(ManagementTimeType.ServoPowerOnTimeTotal);

robot.HighSpeedEServer.Display("Hello from .NET");
```

## Configure the robot

The read methods work in any mode. The commands (servo, motion, job start, file write) need these
settings on the controller.

### Enable the remote commands

- Set the management mode to Security mode.
- Select `IN/OUT` > `PSEUDO INPUT SIGNAL`.
- Move the cursor to `#82015 CMD REMOTE SEL` and press `INTER LOCK` + `SELECT`.

![Enable remote command](https://raw.githubusercontent.com/underautomation/Yaskawa.NET/refs/heads/main/.github/assets/cmd-remote-sel.png)

### Put the key in the remote position

The commands need the key of the pendant in the remote position.

![Pendant remote key](https://raw.githubusercontent.com/underautomation/Yaskawa.NET/refs/heads/main/.github/assets/pendant-remote.png)

To use the key for the remote control, copy `#80011` (key in the remote position) to `#40042` (remote
control enabled) with the ladder editor:

- Set the management mode to Security mode.
- Select `IN/OUT` > `LADDER EDITOR`.
- Check that no other rung writes `#40042`, then add this rung:

![Ladder remote key](https://raw.githubusercontent.com/underautomation/Yaskawa.NET/refs/heads/main/.github/assets/ladder-remote.png)

### Allow the job selection

- Set the management mode to Security mode.
- Select `SETUP` > `FUNCTION ENABLE`.
- Set `JOB SELECT WHEN REMOTE AND PLAY` to `PERMIT`. On the Smart Pendant, set `SC2 224` to `0`.

![Job select when remote and play](https://raw.githubusercontent.com/underautomation/Yaskawa.NET/refs/heads/main/.github/assets/job-select-when-remote-and-play.png)

### Allow the file overwrite

To send a file that already exists on the controller:

- Set the management mode to Security mode.
- Select `PARAMETER` > `RS`.
- Set `RS029` to `1` and `RS214` to `1`.

## Shell sources

The folder [`UnderAutomation.Yaskawa.ObfuscatedSources`](UnderAutomation.Yaskawa.ObfuscatedSources)
contains every public type and member of the SDK, with its XML documentation. The bodies of the methods
are replaced by "Source is hidden". Use it to:

- browse the public API and its documentation on GitHub;
- jump to a definition from your code editor;
- see the structure of the code that is delivered with a source license.

The source license gives the complete source code of the library, with the Visual Studio solution. See
the [license page](https://underautomation.com/yaskawa/documentation/license) of the documentation.

## Compatibility

| Target framework | Supported |
| --- | --- |
| .NET 10.0 / 9.0 / 8.0 / 6.0 / 5.0 | yes |
| .NET Core 3.0 | yes |
| .NET Standard 2.1 / 2.0 | yes |
| .NET Framework 4.0 to 4.8 | yes |
| .NET Framework 3.5 | yes |

- **Operating systems:** Windows, Linux, macOS.
- **No native dependency.** The netstandard2.0 build uses the NuGet package `System.Text.Encoding.CodePages`.
- **Controllers:** Yaskawa YRC1000 (micro), MOTOMAN NEXT, DX100 / DX200, FS100, ERC / XRC / MRC, with the High Speed Ethernet Server.

## License

This SDK needs a commercial license. A 30-day trial starts at the first use, no key needed.

- License agreement: [underautomation.com/yaskawa/eula](https://underautomation.com/yaskawa/eula) and [License.md](License.md)
- Trial, license key and source license: [underautomation.com/yaskawa/documentation/license](https://underautomation.com/yaskawa/documentation/license)
- Prices and quote: [underautomation.com/yaskawa](https://underautomation.com/yaskawa)

## Support

- Documentation: [underautomation.com/yaskawa/documentation](https://underautomation.com/yaskawa/documentation)
- Issues: [GitHub Issues](https://github.com/underautomation/Yaskawa.NET/issues)
- Contact: [underautomation.com/contact](https://underautomation.com/contact)
