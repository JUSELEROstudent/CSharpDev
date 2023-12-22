using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
namespace APP
{
  public static class AppConsole
  {
    static void Main()
    {
      var outer = Task.Factory.StartNew(OuterMethod);
      outer.Wait();
      // var inner = Task.Factory.StartNew(InnerMethod,TaskCreationOptions.AttachedToParent);
      // inner.Wait();
      WriteLine("Console app is stopping");
    }
    static void OuterMethod()
    {
      WriteLine("OuterMethod is starting");
      // var inner = Task.Factory.StartNew(InnerMethod);
      var inner = Task.Factory.StartNew(InnerMethod,TaskCreationOptions.AttachedToParent);
      // inner.Wait();
      WriteLine("OuterMethod is Finished");

    }
    static void InnerMethod()
    {
      WriteLine("innerMethod is starting");
      Thread.Sleep(2000);
      WriteLine("innerMethod is Finished");
    }

  }
}





