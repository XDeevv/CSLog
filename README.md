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
CSLConsole.Log(Types.Info, "MyLog", ConsoleColor.DarkGreen, "This is my info log");
CSLConsole.Log(Types.Info, "MyLog", ConsoleColor.DarkGreen, "This is my info log", "w/ second text");
CSLConsole.Log(Types.Warning, "MyLog", ConsoleColor.DarkGreen, "This is my warning log");
CSLConsole.Log(Types.Warning, "MyLog", ConsoleColor.DarkGreen, "This is my warning log", "w/ second text");
CSLConsole.Log(Types.Error, "MyLog", ConsoleColor.DarkGreen, "This is my error log");
CSLConsole.Log(Types.Error, "MyLog", ConsoleColor.DarkGreen, "This is my error log", "w/ second text");

```

---
© 2022 XarisDev
