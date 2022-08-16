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

        public static void Log(Types type, string name, ConsoleColor color, string message, string secondtext = "")
        {
            switch (type)
            {

                case Types.Trace:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write($"TRACE");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("]   | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
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
                case Types.Notice:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write($"NOTICE");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("]  | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
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
                case Types.Debug:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.DarkCyan;
                    System.Console.Write($"DEBUG");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("]   | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
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

                case Types.Info:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.Write($"INFO");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("]    | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
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
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.Write($"WARNING");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("] | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
                    System.Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write($"ERROR");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("]   | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write($"{message} ");
                    if (secondtext != "")
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.Write($"[{secondtext}]\n");
                    }
                    else if (secondtext == "") { System.Console.Write("\n"); }
                    System.Console.ResetColor();
                    return;

                case Types.Fatal:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.Write($"FATAL");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("]   | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.Write($"{message} ");
                    if (secondtext != "")
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.Write($"[{secondtext}]\n");
                    }
                    else if (secondtext == "") { System.Console.Write("\n"); }
                    System.Console.ResetColor();
                    return;

                case Types.Panic:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write(" [");
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.Write($"PANIC");
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write("] ");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("  | ");
                    System.Console.BackgroundColor = color;
                    System.Console.Write($" {name} ");
                    System.Console.ResetColor();
                    System.Console.Write(" | : ");
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
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
