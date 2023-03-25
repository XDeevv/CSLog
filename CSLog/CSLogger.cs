using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLog.Parsing;
using System.Text.RegularExpressions;

namespace CSLog
{
    public static class CSLogger
	{
        public static void Log(Types logtypes, string Message)
        {
            //Default pattern: h:mm:ss tt [type] : message

            string datetime = DateTime.Now.ToString("h:mm:ss tt");
            string ret = logtypes switch
            {
                Types.Debug => $"<FG=DarkGray>{datetime} <RS>[<FG=DarkCyan>DEBUG<RS>] : {Message}",
                Types.Info => $"<FG=DarkGray>{datetime} <RS>[<FG=Green>INFO<RS>] : {Message}",
                Types.Warning => $"<FG=DarkGray>{datetime} <RS>[<FG=DarkYellow>WARNING<RS>] : <FG=DarkYellow>{Message}",
                Types.Error => $"<FG=DarkGray>{datetime} <RS>[<FG=Red>ERROR<RS>] : <FG=Red>{Message}",
                Types.Critical => $"<FG=DarkGray>{datetime} <RS>[<FG=DarkRed>CRITICAL<RS>] : <FG=DarkRed>{Message}",
                _ => throw new InvalidTypeException()
            };

            CSLParser.ParseStringWithLine(ret);
		}

		public static void LogWithCustomProfile(CSLCustom customprofile, string Message, params string[] Extra)
		{
			string datetime = DateTime.Now.ToString("h:mm:ss tt");
			string input = customprofile.pattern;

			string output = input.Replace("{Message}", Message).Replace("{Timestamp}", datetime);

			for (int i = 0; i < Extra.Length; i++)
			{
				string exKey = "{EX=" + i.ToString() + "}";
				if (input.Contains(exKey))
				{
					int exValue;
					if (int.TryParse(Extra[i], out exValue))
						output = output.Replace(exKey, exValue.ToString());
					else
						output = output.Replace(exKey, Extra[i]);
				}
			}

			CSLParser.ParseStringWithLine(output);
		}


	}
}

