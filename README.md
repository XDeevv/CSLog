![image](https://img.shields.io/badge/Version-0.0.0-red)
![image](https://img.shields.io/badge/license-MIT-green)
![image](https://img.shields.io/badge/Lines_of_code-2.9k-black)


# What is CSLog?
CSLog is a simple logging library for `c#` and other `.net` applications like `visual basic`. Its made using no third-party libraries and it even has a built in input (question) system. Its open source and completely free to use and modify



#### Download:
- 🌐 Download for NuGet: `not up yet`
- 💿 Download from the releases tab: https://github.com/vp10gr/CSLog/releases/

#### Instructions:
- Download CSLog.dll
- Make it a dependency in your project
- Add ``using CSLog;`` on your main script

![img](https://cdn.discordapp.com/attachments/1042808931434639491/1088899007641829417/cslscreenshot.png)
 

# Examples

### Logging abilities 

```cs
CSLogger.Log(Types.Debug, "Debug log");
CSLogger.Log(Types.Info, "Info log");
CSLogger.Log(Types.Warning, "Warning log");
CSLogger.Log(Types.Error, "Error log");
CSLogger.Log(Types.Critical, "Critical log");
```
# Create custom logs
```cs
CSLCustom pattern = new CSLCustom("<BG=DarkBlue><FG=Yellow>{Timestamp} <FG=Red>[CUSTOM] <FG=Gray>: <FG=Green>{Message}");
CSLogger.LogWithCustomProfile(pattern, "Custom log");
```

---
© 2022 XDev
