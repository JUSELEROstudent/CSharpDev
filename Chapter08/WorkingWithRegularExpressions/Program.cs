using static System.Console;
using System.Text.RegularExpressions;

namespace AppConsole
{
  public class ConsoleApp
  {
    public static void Main()
    {
      Write("Enter your age : ");
      string input = ReadLine();
      var ageChecker = new Regex(@"^[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]{3}$");
      if (ageChecker.IsMatch(input))
      {
        WriteLine("Than you.");
      }
      else
      {
        WriteLine($"This is not a valid age:{input}");

      }
    }
  }
}