using static System.Console;
using Packt.Shared;
using Microsoft.VisualBasic;
using System.Diagnostics;


namespace appConsole;

public class ConsoleApp
{
  static void Main()
  {
    var bob = new Person();
    bob.Name = "Bob smith";
    bob.DateOfBirth =new DateTime(1998, 3,7);
    // bob.FavoriteAncientWonder= WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
    //     WriteLine(
    //   format: "{0} favorites wonder is {1}. it's Index is {2}",
    //   arg0:bob.Name,
    //   arg1:bob.FavoriteAncientWonder,
    //   arg2:(int)bob.FavoriteAncientWonder
    // );
    // var alice = new Person()    
    // {
    //   Name = "alice",
    //   DateOfBirth = new DateTime(1995, 10,15)
    // };
    // WriteLine(
    //   format: "{0} was born on {1:dddd, d MMMM yyyy}",
    //   arg0:alice.Name,
    //   arg1:alice.DateOfBirth
    // );
    //   bob.FavoriteAncientWonder= WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
    //   WriteLine(
    //   format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    //   arg0:bob.Name,
    //   arg1:bob.HomePlanet,
    //   arg2:bob.Instantiated
    // );
    // var sebastian = new Person("Sebastian", new DateTime(1995,10,15));
    // WriteLine(
    //   format: "{0} was born at {1:dddd, d MMMM yyyy}  and Instantiated in {2}",
    //   arg0:sebastian.Name,
    //   arg1:sebastian.DateOfBirth,
    //   arg2:sebastian.Instantiated
    // );
        var sebastian = new Person("Sebastian", new DateTime(1995,10,15));

        // sebastian.WriteToConsole();
        // WriteLine(sebastian.GetOrigin());
      // WriteLine(sebastian.OptionalParameters("scape!",command:"NO OPCIONAL"));
      // int a= 10;
      // int b=20;
      // int c=30;
      //  WriteLine($"Before pasin a = {a} , b = {b} , c = {c}");
      //  sebastian.PassingParameters(a,ref b,out c);
      //  WriteLine($"Before pasin a = {a} , b = {b} , c = {c}");
    var camila = new Person{
      Name = "Camila",
      DateOfBirth = new DateTime(2000,1,27)
    };
    // WriteLine(camila.Origin);
    // WriteLine(camila.Greeting);
    // WriteLine(camila.Age);
    camila.FavoriteIceCream = "chocolate fudge";
    WriteLine($"sams favorite ice-cream flcor is {camila.FavoriteIceCream}.");
    camila.FavoritePrimaryColor = "RED";
    WriteLine($"sams favorite primary color is {camila.FavoritePrimaryColor}.");
    }

    
}
public static class overridetext
    {
      public static string getFirstletter(this string value)
      {
        return value[1].ToString();
      }
    }