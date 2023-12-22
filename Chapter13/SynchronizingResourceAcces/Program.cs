using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
namespace App
{
  public class ConsoleApp
  {
    static Random r = new Random();
    static string Message;
    static object conch = new object();

    public static void Main()
    {
      WriteLine("Please wait for the tasks to complete.");
       Stopwatch watch = Stopwatch.StartNew();
       Task a = Task.Factory.StartNew(methodA);
       Task b = Task.Factory.StartNew(methodB);
       Task c = Task.Factory.StartNew(methodC);
       Task.WaitAll(new Task[] { a, b,c });
      WriteLine();
      WriteLine($"Results: {Message}.");
      WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed milliseconds.");
    }

    static void methodA()
    { lock(conch)
      {
    for(int i = 0 ; i<5;i++)
      {
        Thread.Sleep(r.Next(2000));
        Message += "A";
        Write(".");
      }
      }
    }
    static void methodB()
    {
      try
      {
        Monitor.TryEnter(conch, TimeSpan.FromSeconds(15));
        for(int i = 0 ; i<5;i++)
        {
          Thread.Sleep(r.Next(2000));
          Message += "B";
          Write(".");
        }
      }
      finally
      {
        Monitor.Exit(conch);
      }
    }
    static void methodC()
    {
      lock(conch)
      {
        for(int i = 0 ; i<5;i++)
        {
          Thread.Sleep(r.Next(2000));
          Message += "C";
          Write(".");
        }
      }
    }
  }
}