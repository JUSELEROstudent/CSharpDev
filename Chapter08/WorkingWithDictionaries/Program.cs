using static System.Console;

namespace AppConsole
{
  public class ConsoleApp
  {
    public static void Main()
    {
      var keywords = new Dictionary<string, string>();
      keywords.Add("int", "32_bit integer dadta type");
      keywords.Add("long", "64_bit intger data type");
      keywords.Add("float", "single precision floating point number ");
      WriteLine("keywords and their definitions"); 
      foreach(var item in keywords)
      {
        WriteLine($" {item.Key}:{item.Value}");

      }
      WriteLine($"the definition of long is {keywords["long"]}");

    }
  }
}