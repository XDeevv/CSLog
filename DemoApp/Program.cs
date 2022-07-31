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
//End