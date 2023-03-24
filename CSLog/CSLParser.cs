using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLog.Parsing
{
	public class CSLParser
	{
		public static void ParseString(string str)
		{
			ConsoleColor fgcolor;
			ConsoleColor bgcolor;

			if (string.IsNullOrEmpty(str))
				return;

			string[] splitted = str.Split('<', '>');
			foreach (var clr in splitted)
			{
				if (clr.StartsWith("RS"))
					Console.ResetColor();
				else if (clr.StartsWith("FG=") && Enum.TryParse(clr.Substring(3), out fgcolor))
					Console.ForegroundColor = fgcolor;
				else if (clr.StartsWith("BG=") && Enum.TryParse(clr.Substring(3), out bgcolor))
					Console.BackgroundColor = bgcolor;
				else
					Console.Write(clr);
			}
			Console.ResetColor();
		}
		public static void ParseStringWithLine(string str)
		{
			string output = str.Insert(str.Length ,"\n");
			ParseString(output);
		}
	}
}
