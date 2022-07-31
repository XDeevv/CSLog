using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLog
{
    public static class CSLConsole
    {
        public static void Clear(int time = 0)
        {
            if (time == 0) { System.Console.Clear(); }
            else if (time != 0)
            {
                Thread.Sleep(time);
                System.Console.Clear();
            }
        }

        public static void Log( Types type, string message, string secondtext = "")
        {
            switch (type)
            {
                case Types.Info:
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write("*");
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write("] ");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write($"{message} ");
                    if (secondtext != "")
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.Write($"[{secondtext}]\n");
                    }
                    else if (secondtext == "") { System.Console.Write("\n"); }
                    System.Console.ResetColor();
                    return;
                case Types.Warning:
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write("!");
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write("] ");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write($"{message} ");
                    if (secondtext != "")
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.Write($"[{secondtext}]\n");
                    }
                    else if (secondtext == "") { System.Console.Write("\n"); }
                    System.Console.ResetColor();
                    return;

                case Types.Error:
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.Write("E");
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write("] ");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write($"{message} ");
                    if (secondtext != "")
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.Write($"[{secondtext}]\n");
                    }
                    else if (secondtext == "") { System.Console.Write("\n"); }
                    System.Console.ResetColor();
                    return;

                default:
                    throw new InvalidTypeException();
            }
        }
    }
}
