using System;
using Packt.Shared;
using static System.Console;

namespace appconsole;

class ConsoleApp
{
  public static void Main()
  {
    var sebastian = new  Person 
    {
      Name =  "Sebastian"
    };
    var mary = new  Person{Name =  "Mary"};
    var jill = new  Person{Name =  "Jill"};
    var baby1 = mary.ProcreateWith(sebastian);
    var baby2 = Person.Procreate(sebastian,jill);
    //call an operator
    // var baby3 = sebastian * mary;

    // WriteLine($"{sebastian.Name} has {sebastian.Children.Count} children.");
    // WriteLine($"{mary.Name} has {mary.Children.Count} children.");
    // WriteLine($"{jill.Name} has {jill.Children.Count} children.");
    // WriteLine( 
    //    format: "{0}'s first child is named \"{1}\".",
    //      arg0: sebastian.Name,
    //      arg1: sebastian.Children[0].Name
    //      );

    // WriteLine($"5! is {Person.Factorial(100)}");
    int answer = sebastian.MethodWnatToCall("DOG");

    // var d = new DelegateWithMatchingSignature(sebastian.MethodWnatToCall);
    // HANDLING DELEGATES 
    // sebastian.Shout += Sebastian_Shout;
    // sebastian.Shout += Sebastian_Shout;
    // sebastian.Poke();
    // sebastian.Poke();
    // sebastian.Poke();
    // sebastian.Poke();

  // use a interface to implement methods to sort arrrys
    Person[] people = {
      new Person {Name="Xndolfo" },
      new Person {Name="Serafin"},
      new Person {Name="Gustavo"},
      new Person {Name="Natilo"}
    };
    WriteLine("Initial lis of people");
    foreach (Person uniq in people){
      WriteLine($"{uniq.Name}");
    }

    WriteLine("use Persons IComparable implementation to sort:");
    Array.Sort(people);
    foreach(var person in people)
    {
      WriteLine($"{person.Name}");
    }

  // Comparing objects using separate clases
  WriteLine("Use personcomparrers IComaparer to sort ");
  Array.Sort(people,new PersonComparer());
  foreach (var person in people){
    WriteLine($"{person.Name}");
    
  }





  }
  private static void Sebastian_Shout(Object sender, EventArgs e)
  {
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry : {p.AngerLevel}");
  }
}