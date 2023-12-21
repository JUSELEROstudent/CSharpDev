using static System.Console;
using System.Net;

namespace AppConsole
{
  public class ConsoleApp
  {
    public static void Main()
    {
      WriteLine("enter a valid web addres");
      string url = ReadLine();
      if(string.IsNullOrWhiteSpace(url))
      {
        url =  "https://world.episerver.com/cms/?q=pagetype";
      }
      var uri = new Uri(url);
      WriteLine($"URL: {url}");
      WriteLine($"Scheme: {uri.Scheme}");
      WriteLine($"Port: {uri.Port}");
      WriteLine($"Host: {uri.Host}");
      WriteLine($"Path: {uri.AbsolutePath}");
      WriteLine($"Query: {uri.Query}");
    }
  }
}