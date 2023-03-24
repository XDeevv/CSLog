using CSLog;
using CSLog.Parsing;
using System;

namespace DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CSLCustom pattern = new CSLCustom("<BG=DarkBlue><FG=Yellow>{Timestamp} <FG=Red>[CUSTOM] <FG=Gray>: <FG=Green>{Message}");

			CSLogger.Log(Types.Debug, "Debug log");
			CSLogger.Log(Types.Info, "Info log");
			CSLogger.Log(Types.Warning, "Warning log");
			CSLogger.Log(Types.Error, "Error log");
			CSLogger.Log(Types.Critical, "Critical log");
            Console.WriteLine();
            CSLogger.LogWithCustomProfile(pattern, "Custom log");
		}
    }
}