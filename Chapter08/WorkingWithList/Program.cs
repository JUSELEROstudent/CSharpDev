using static System.Console;
using System.Collections.Generic;

namespace AppConsole
{
  public class ConsoleApp
  {
    public static void Main()
    {
      var cities = new List<string>();
      cities.Add("London");
      cities.Add("Paris");
      cities.Add("Milan");
      WriteLine("intial list");
      foreach(var city in cities)
      {
        WriteLine($"{city}");
      }
      WriteLine($"The firs city is : {cities[0]}");
      WriteLine($"The last city is : {cities[cities.Count()-1]}.");
      cities.Insert(0,"Sydney");
      WriteLine($"After insertin Sydney index 0 ");
      foreach(var city in cities)
      {
        WriteLine($"{city}");
      }
      cities.RemoveAt(1);
      cities.Remove("Milan");
      WriteLine("After removing two cities");
      foreach(var city in cities)
      {
        WriteLine($"{city}");
      }

    }
  }
}