using CSLog;
using CSLog.Parsing;
using System;

namespace DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CSLCustom pattern = new CSLCustom("<FG=DarkGray>{Timestamp} <RS>[<FG={EX=3}>{EX=2}<RS>] | <BG={EX=1}><FG=Black>{EX=0}<RS> | : {Message}");

			CSLogger.Log(Types.Debug, "Debug log");
			CSLogger.Log(Types.Info, "Info log");
			CSLogger.Log(Types.Warning, "Warning log");
			CSLogger.Log(Types.Error, "Error log");
			CSLogger.Log(Types.Critical, "Critical log");
            Console.WriteLine();
            CSLogger.LogWithCustomProfile(pattern, "Custom log", "Server", "Blue", "Custom", "Magenta");
		}
    }
}
