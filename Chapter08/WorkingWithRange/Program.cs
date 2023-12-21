using static System.Console;
namespace AppConsole
{

  public class ConsoleApp
  {
    public static void Main ()
    {
      string name= "Samantha Jones";
      int lengthOfFirst = name.IndexOf(' ');
      int lengthOfLast = name.Length -name.IndexOf(' ');
      string firstName =name.Substring(
        startIndex: 0,
        length: lengthOfFirst
      );
      string lastName = name.Substring(
        startIndex:name.Length - lengthOfLast,
        length: lengthOfLast
      );
      WriteLine($"firstName : {firstName}, lastName : {lastName }");
      ReadOnlySpan<char>nameAsSpan = name.AsSpan();
      var firstNameSpan = nameAsSpan[0..lengthOfFirst];
      var lastNameSpan = nameAsSpan[^lengthOfLast..^0];
      WriteLine("firstName : {0}, lastName : {1}",
        arg0: firstNameSpan.ToString(),
        arg1: lastNameSpan.ToString()
      );
      Range r3 = 3..6;

      
    }
  }
}