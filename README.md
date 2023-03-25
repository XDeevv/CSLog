![image](https://img.shields.io/badge/Version-2.0.1-red)
![image](https://img.shields.io/badge/License-MIT-green)
![image](https://img.shields.io/badge/Lines_of_code-4.7k-blue)


# What is CSLog?
CSLog is a simple logging library for `c#` and other `.net` applications like `visual basic`. Its made using no third-party libraries. Its open source and completely free to use and modify



#### Download:
- 🌐 Download from NuGet: `not up yet`
- 💿 Download from the releases tab: https://github.com/vp10gr/CSLog/releases/

#### Instructions:
- Download ``CSLog.dll``
- Make it a dependency in your project
- Add ``using CSLog;`` on your main script
- You can skip the first two parts if you download it from ``NuGet``

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
### Create custom logs
```cs
CSLCustom pattern = new CSLCustom("<BG=DarkBlue><FG=Yellow>{Timestamp} <FG=Red>[CUSTOM] <FG=Gray>: <FG=Green>{Message}");
CSLogger.LogWithCustomProfile(pattern, "Custom log");
```
- Use ``{Timestamp}`` and ``{Message}`` to define where the timestamp and the message goes
- Use the ``<BG=Color>`` and the ``<FG=Color>`` tag to define the log colors
- You can also use the ``<RS>`` Tag to reset the colors

![img](https://cdn.discordapp.com/attachments/1042808931434639491/1088901126524506302/image.png)
---
© 2023 XDev
