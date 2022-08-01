![image](https://img.shields.io/badge/Version-0.0.0-red)
![image](https://img.shields.io/badge/license-MIT-green)
![image](https://img.shields.io/badge/Lines_of_code-2.9k-black)
![Your Repository's Stats](https://github-readme-stats.vercel.app/api?username=XarisDev&show_icons=true)


# What is CSLog?
CSLog is a simple logging library for `c#` and other `.net` applications like `visual basic`. Its made using no third-party libraries and it even has a built in input (question) system. Its open source and completely free to use and modify



#### Download:
- 🌐 Download for NuGet: `not up yet`
- 💿 Download from the releases tab: https://github.com/vp10gr/CSLog/releases/tag/CSL

 

# Examples 

### User input

```cs
using CSLog;
namespace DemoApp
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine();
            CSLQuestion.Ask("Yes or no");
            if (CSLQuestion.UAnswer == CSLQuestion.Answer.Yes)
                CSLConsole.Log(Types.Info, $"Answer: Yes", $"{{{CSLQuestion.WAnswer}, {CSLQuestion.UAnswer}}}");
            else
                CSLConsole.Log(Types.Warning, $"Answer: No", $"{{{CSLQuestion.WAnswer}, {CSLQuestion.UAnswer}}}");
        }
    }
}

```

### Logging abilities 

```cs
using CSLog;

namespace DemoApp
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            CSLConsole.Log(Types.Info, "This is an info message");
            CSLConsole.Log(Types.Info, "This is an info message", "With second text");
            CSLConsole.Log(Types.Warning, "This is an warning message");
            CSLConsole.Log(Types.Warning, "This is an warning message", "With second text");
            CSLConsole.Log(Types.Error, "This is an error message");
            CSLConsole.Log(Types.Error, "This is an error message", "With second text");
        }
    }
}

```


### Clear console

```cs
using CSLog;

namespace DemoApp
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            CSLConsole.Clear(5000); //It clears the console in 5 seconds
        }
    }
}

```

---
© 2022 XarisDev
