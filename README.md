# Yaskawa Communication SDK

[![UnderAutomation Yaskawa communication SDK](https://raw.githubusercontent.com/underautomation/yaskawa.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com)

[![NuGet](https://img.shields.io/nuget/dt/UnderAutomation.Yaskawa?label=NuGet%20Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.Yaskawa/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0+-blueviolet)](#)
[![.NET Core](https://img.shields.io/badge/.NET_Core-2.0+-blueviolet)](#)
[![.NET Versions](https://img.shields.io/badge/.NET-5_6_8_9-blueviolet)](#)

### 🤖 Effortlessly Communicate with Yaskawa robots

The **Yaskawa SDK** enables seamless integration with Yaskawa robots for automation, data exchange, and remote control. Ideal for industrial automation, research, and advanced robotics applications.

🔗 **More Information:** [https://underautomation.com/yaskawa](https://underautomation.com/yaskawa)  
🔗 Also available for **[🟨 LabVIEW](https://github.com/underautomation/yaskawa.vi)** & **[🐍 Python](https://github.com/underautomation/yaskawa.py)**

---

[⭐ Star if you like it !](https://github.com/underautomation/yaskawa.NET/stargazers)

[👁️ Watch to be notified of latest updates !](https://github.com/underautomation/yaskawa.NET/watchers)

---

## 🚀 TL;DR (Too Long; Didn’t Read)

No additional installations or Yaskawa options are required to use this SDK.

---

## 📥 Download Example Applications

Explore the **Yaskawa SDK** with fully functional example applications and precompiled binaries for various platforms. [See Github releases](https://github.com/underautomation/yaskawa.NET/releases)

### 🔹 Windows Forms Application (Full Feature Showcase)

A Windows Forms application demonstrating all the features of the library.

📌 **Download:** [📥 UnderAutomation.Yaskawa.Showcase.Forms.exe](https://github.com/underautomation/yaskawa.NET/releases/latest/download/UnderAutomation.Yaskawa.Showcase.Forms.exe)

<p align="center">
    <img src="https://raw.githubusercontent.com/underautomation/yaskawa.NET/refs/heads/main/.github/assets/read-variables.gif" >
    <img src="https://raw.githubusercontent.com/underautomation/yaskawa.NET/refs/heads/main/.github/assets/move-robot.gif" >
    <img src="https://raw.githubusercontent.com/underautomation/yaskawa.NET/refs/heads/main/.github/assets/snpx.gif" >
</p>

---

## 📌 Features

---

## 🛠 Installation

### 1️⃣ **Get the SDK**

Choose the installation method that works best for you:

| Method             | NuGet (Recommended)                                                                       | Direct Download                                                                                                        |
| ------------------ | ----------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| **How to Install** | Install via NuGet. [See on Nuget](https://www.nuget.org/packages/UnderAutomation.Yaskawa) | Download and reference the DLL manually                                                                                |
|                    | `dotnet add package UnderAutomation.Yaskawa `                                             | 📥 [Download ZIP](https://github.com/underautomation/yaskawa.NET/releases/latest/download/UnderAutomation.Yaskawa.zip) |

### 2️⃣ **Reference the SDK in Your Code**

```csharp
using UnderAutomation.Yaskawa;
```

### 3️⃣ **Connect to Your Robot**

```csharp
var robot = new YaskawaRobot();
robot.Connect(new ConnectParameters("192.168.0.1"));
```

---

## 🔍 Compatibility

✅ **Supported Robots:**
✅ **Operating Systems:** Windows, Linux, macOS  
✅ **.NET Versions:** .NET Framework (≥3.5), .NET Standard, .NET Core, .NET 5/6/8/9

---

## 📢 Contributing

We welcome contributions! Feel free to:

- Report issues via [GitHub Issues](https://github.com/underautomation/Yaskawa.NET/issues)
- Submit pull requests with improvements
- Share feedback & feature requests

---

## 📜 License

**⚠️ This SDK requires a commercial license.**  
🔗 Learn more: [UnderAutomation Licensing](https://underautomation.com/yaskawa/eula)

---

## 📬 Need Help?

If you have any questions or need support:

- 📖 **Check the Docs**: [Documentation](https://underautomation.com/yaskawa/documentation)
- 📩 **Contact Us**: [Support](https://underautomation.com/contact)
