using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSLog.Parsing
{
	public class CSLParser
	{
		public static void ParseString(string str)
		{
			if (string.IsNullOrEmpty(str))
				return;

			var splitted = Regex.Split(str, @"(<[^>]+>)");

			var currentForegroundColor = Console.ForegroundColor;
			var currentBackgroundColor = Console.BackgroundColor;

			foreach (var tag in splitted)
			{
				if (string.IsNullOrEmpty(tag))
					continue;

				if (tag.StartsWith("<RS>"))
				{
					Console.ResetColor();
					continue;
				}

				var match = Regex.Match(tag, @"<FG=(\w+)>", RegexOptions.IgnoreCase);
				if (match.Success && Enum.TryParse(match.Groups[1].Value, true, out ConsoleColor fgColor))
				{
					Console.ForegroundColor = fgColor;
					continue;
				}

				match = Regex.Match(tag, @"<BG=(\w+)>", RegexOptions.IgnoreCase);
				if (match.Success && Enum.TryParse(match.Groups[1].Value, true, out ConsoleColor bgColor))
				{
					Console.BackgroundColor = bgColor;
					continue;
				}

				Console.Write(tag);
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
