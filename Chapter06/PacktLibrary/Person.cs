using System.Collections.Generic;
using static System.Console;

using System;
namespace Packt.Shared
{
  public class Person : IComparable<Person>
  {
    
    public string Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new List<Person>();
    public void WriteToConsole()
    {
      WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
    public static Person Procreate(Person P1, Person P2)
    {
      var baby = new Person
      {
        Name= $"Baby of {P1.Name} and {P2.Name}"
      };
      P1.Children.Add(baby);
      P2.Children.Add(baby);

      return baby;
    }
    public Person ProcreateWith(Person partner)
    {
      return Procreate(this,partner);
    }

    /// <summary>
    /// * operator now is abailable to behavior like a method and could work whit 2 elements from same class
    /// </summary>
    /// <param name="P1"></param>
    /// <param name="P2"></param>
    /// <returns></returns>
    public static Person operator *(Person P1,Person P2)
    {
      return Person.Procreate(P1,P2);
    }

    public static int Factorial(int number)
    {
      if(number < 0 )
      {
        throw new ArgumentException(
          $"{nameof(number)} cannot be less than zeron."
        );

      }
      return localFactorial(number);
      int localFactorial(int localNumber)
      {
        if(localNumber < 1) return 1;
        return localNumber * localFactorial(localNumber-1);
      }
    }
    public int MethodWnatToCall(string input)
    {
      return input.Length;
    }
    delegate int DelegateWithMatchingSignature(string s);

    public event EventHandler Shout;
    public int AngerLevel;
    public void Poke()
    {
      AngerLevel++;
      if (AngerLevel >= 3)
      {
        if (Shout != null)
        {
          // Call method defines to the events pass himself and event empty
          Shout?.Invoke(this, EventArgs.Empty);
        }
      }
    }

    public int CompareTo(Person? other)
    {
      return Name.CompareTo(other.Name);
    }
  }
}

