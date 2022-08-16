using CSLog;
namespace DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CSLConsole.Log(Types.Trace, "Client", ConsoleColor.Magenta, "This is my trace log");
            CSLConsole.Log(Types.Trace, "Server", ConsoleColor.Blue, "This is my trace log", "w/ second text");
            CSLConsole.Log(Types.Notice, "Client", ConsoleColor.Magenta, "This is my notice log");
            CSLConsole.Log(Types.Notice, "Server", ConsoleColor.Blue, "This is my notice log", "w/ second text");
            CSLConsole.Log(Types.Debug, "Client", ConsoleColor.Magenta, "This is my debug log");
            CSLConsole.Log(Types.Debug, "Client", ConsoleColor.Magenta, "This is my debug log", "w/ second text");
            CSLConsole.Log(Types.Info, "Client", ConsoleColor.Magenta, "This is my info log");
            CSLConsole.Log(Types.Info, "Server", ConsoleColor.Blue, "This is my info log", "w/ second text");
            CSLConsole.Log(Types.Warning, "Client", ConsoleColor.Magenta, "This is my warning log");
            CSLConsole.Log(Types.Warning, "Client", ConsoleColor.Magenta, "This is my warning log", "w/ second text");
            CSLConsole.Log(Types.Error, "Server", ConsoleColor.Blue, "This is my error log");
            CSLConsole.Log(Types.Error, "Server", ConsoleColor.Blue, "This is my error log", "w/ second text");
            CSLConsole.Log(Types.Fatal, "Client", ConsoleColor.Magenta, "This is my fatal log");
            CSLConsole.Log(Types.Fatal, "Server", ConsoleColor.Blue, "This is my fatal log", "w/ second text");
            CSLConsole.Log(Types.Panic, "Client", ConsoleColor.Magenta, "This is my panic log");
            CSLConsole.Log(Types.Panic, "Server", ConsoleColor.Blue, "This is my panic log", "w/ second text");
        }
    }
}