using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLog
{
    public static class CSLQuestion
    {
        public enum Answer
        {
            Yes = 1,
            No = 0,
        }

        public static Answer UAnswer;
        public static string? WAnswer;
        public static void Ask(string name, ConsoleColor color, string message)
        {
            while (true)
            {

                System.Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write(" [");
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write($"QUESTION");
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("] | ");
                System.Console.BackgroundColor = color;
                System.Console.Write($" {name} ");
                System.Console.ResetColor();
                System.Console.Write(" | : ");
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write($"{message}(Y/n) ");

                string? answer = System.Console.ReadLine().ToString();
                WAnswer = answer;
                if (answer != "")
                {
                    if (answer == "Y" || answer == "y" || answer == "Yes" || answer == "yes")
                    {
                        //Set the object answer to yes
                        UAnswer = Answer.Yes;
                        break;
                    }
                    else if (answer == "N" || answer == "n" || answer == "No" || answer == "no")
                    {
                        //Set the bject answer to no
                        UAnswer = Answer.No;
                        break;
                    }
                    else
                        CSLConsole.Log(Types.Error, "Question", ConsoleColor.DarkRed, "Not a valid answer");
                }
                else
                    CSLConsole.Log(Types.Error, "Question", ConsoleColor.DarkRed, "Not a valid answer");
            }
        }
    }
}
