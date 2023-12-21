using System;
using System.IO.Compression;
using static System.Console;
namespace Packt.Shared;

public partial class Person : Object
{
  public string Name;
  public DateTime DateOfBirth;
  public WondersOfTheAncientWorld FavoriteAncientWonder;
  public const string Species= "Homo sapiens ";
  
  public readonly string HomePlanet = "Earth";
  public readonly DateTime Instantiated;

  public Person()
  {
    Name = "Unknown";
    Instantiated =DateTime.Now;
  }

  public Person(string Nombre, DateTime dateOfB)
  {
    Name= Nombre;
    DateOfBirth = dateOfB;
    Instantiated = DateTime.Now;
  }

  public void WriteToConsole()
  {
     WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
  }
  public string GetOrigin()
  {
     return $"{Name} was born on {HomePlanet}."; 
  }
  public string OptionalParameters(string nooptional,string command = "Run!", double number = 0.0, bool active = true )
  {
    return string.Format("primera funcion {0}  number  {1} active is {2}",nooptional,number,active);
  }
  /// <summary>
  /// duplicated method same to previos one but, is diferent by one of them optional imputs
  /// </summary>
  /// <param name="nooptional"></param>
  /// <param name="number"></param>
  /// <param name="active"></param>
  /// <param name="secondoptional"></param>
  /// <returns></returns>
    public string OptionalParameters(string nooptional, double number = 0.0, bool active = true, string secondoptional ="" )
  {
    return string.Format("llamada opcional {0}  llamada obligatoria  {1}SE PARECE PERO NO ES {2}",secondoptional,nooptional,active);
  }
  public void PassingParameters(int x, ref int y, out int z)
  {
    z =99;
    x++;
    y++;
    z++;
    
  }
}
