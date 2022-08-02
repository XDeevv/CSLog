![image](https://img.shields.io/badge/Version-0.0.0-red)
![image](https://img.shields.io/badge/license-MIT-green)
![image](https://img.shields.io/badge/Lines_of_code-2.9k-black)


# What is CSLog?
CSLog is a simple logging library for `c#` and other `.net` applications like `visual basic`. Its made using no third-party libraries and it even has a built in input (question) system. Its open source and completely free to use and modify



#### Download:
- 🌐 Download for NuGet: `not up yet`
- 💿 Download from the releases tab: https://github.com/vp10gr/CSLog/releases/tag/CSL

 

# Examples 

### User input

```cs
Console.WriteLine();
CSLQuestion.Ask("Question", ConsoleColor.DarkRed, "Yes or no?"); //Pattern: string log name, color log color, string message 
if (CSLQuestion.UAnswer == CSLQuestion.Answer.Yes) //UAnswer = users answer, enum Answer
   CSLConsole.Log(Types.Info, "Answer", ConsoleColor.DarkGreen, $"{{{CSLQuestion.WAnswer}, {CSLQuestion.UAnswer}}}"); //Code here
else
   CSLConsole.Log(Types.Info, "Answer", ConsoleColor.DarkGreen, $"{{{CSLQuestion.WAnswer}, {CSLQuestion.UAnswer}}}"); //Code here

```

### Logging abilities 

```cs
using CSLog;

CSLConsole.Log(Types.Info, "MyLog", ConsoleColor.DarkGreen, "This is my info log");
CSLConsole.Log(Types.Info, "MyLog", ConsoleColor.DarkGreen, "This is my info log", "w/ second text");
CSLConsole.Log(Types.Warning, "MyLog", ConsoleColor.DarkGreen, "This is my warning log");
CSLConsole.Log(Types.Warning, "MyLog", ConsoleColor.DarkGreen, "This is my warning log", "w/ second text");
CSLConsole.Log(Types.Error, "MyLog", ConsoleColor.DarkGreen, "This is my error log");
CSLConsole.Log(Types.Error, "MyLog", ConsoleColor.DarkGreen, "This is my error log", "w/ second text");

```


### Clear console

```cs
CSLConsole.Clear(5000); //It clears the console in 5 seconds

```

---
© 2022 XarisDev
