![image](https://img.shields.io/badge/Version-2.0.1-red)
![image](https://img.shields.io/badge/License-GPL_3.0-green)
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

![img](https://cdn.discordapp.com/attachments/936652528966320168/1089170709722439700/image.png)
 

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
CSLCustom pattern = new CSLCustom("<FG=DarkGray>{Timestamp} <RS>[<FG={EX=3}>{EX=2}<RS>] | <BG={EX=1}><FG=Black>{EX=0}<RS> | : {Message}");
CSLogger.LogWithCustomProfile(pattern, "Custom log", "Server", "Blue", "Custom", "Magenta");
```
- Use ``{Timestamp}`` and ``{Message}`` to define where the timestamp and the message goes
- Add a ``,`` next to the title and then use ``{EX=number}`` to set the text it must start with a ``0``
- Use the ``<BG=Color>`` and the ``<FG=Color>`` tag to define the log colors
- You can also use the ``<RS>`` Tag to reset the colors

![img](https://cdn.discordapp.com/attachments/936652528966320168/1089170767121494036/image.png)
---
© 2023 XDev
