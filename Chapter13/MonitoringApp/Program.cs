using System.Linq;
using Packt.Shared;
using static System.Console;
namespace MonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine("Processing. Please wait...");
            // Recorder.Start();
            // // simulate a process that requires some memory resources...      
            // int[] largeArrayOfInts = Enumerable.Range(1, 10_000).ToArray();
            // // ...and takes some time to complete      
            // System.Threading.Thread.Sleep(
            //     new Random().Next(5, 10) * 1000);
            // Recorder.Stop();
  //suma de caraccteres string        
            // int[] numbers = Enumerable.Range(1, 50_000).ToArray();
            // Recorder.Start();
            // WriteLine("Using string with +"); 
            // string s = "";
            // for (int i = 0; i < numbers.Length; i++)
            // {  s += numbers[i] + ", ";
            
            // }Recorder.Stop();
            // Recorder.Start();
            //  WriteLine("--Using StringBuilder");
            // var builder = new System.Text.StringBuilder();
            // for (int i = 0; i < numbers.Length; i++)
            // { 
            //      builder.Append(numbers[i]);
            //      builder.Append(", ");
            // }
            // Recorder.Stop();
            WriteLine("Passing ressultat from one task as imput of other");
            var taskCallWebServiceAndThenStoredProcedure = Task.Factory.StartNew(CallWebService)
            .ContinueWith(previousTask =>
            CallStoredProcedure(previousTask.Result));
            WriteLine($"Reslult: {taskCallWebServiceAndThenStoredProcedure.Result}");


        }

        static decimal CallWebService()
        {
          WriteLine("calling to stored procedure");
          Thread.Sleep((new Random()).Next(2000,4000));
          WriteLine("ENd call to stored precedure ");
          return 89.99M;
        }
        static string CallStoredProcedure(decimal amount)
        {
          WriteLine("calling to web services");
          Thread.Sleep((new Random()).Next(2000,4000));
          WriteLine("ENd call to web service ");
          return $"12 products cost more than {amount:C}";
        }
    }
}