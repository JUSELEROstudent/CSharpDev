using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace App
{
  public class AppConsole
  {
    public static async Task Main()
    {
      await foreach( int number in GetNumbers())
      {
        WriteLine($"Number : {number}");
      }
    }
    static async IAsyncEnumerable<int> GetNumbers()
    {
      var r =new Random();
      System.Threading.Thread.Sleep(r.Next(1000,2000));
      yield return r.Next(0,101);
      System.Threading.Thread.Sleep(r.Next(1000,2000));
      yield return r.Next(0,101);
      System.Threading.Thread.Sleep(r.Next(1000,2000));
      yield return r.Next(101,204);

    }
  }
}