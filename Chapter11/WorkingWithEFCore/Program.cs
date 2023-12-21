using static System.Console;
using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConsoleApp
{
  static class AppConsole
  {
    public static void Main()
    {
      QueryingCategorie();
    }
    static void QueryingCategorie()
    {
      using (var db = new Northwind())
      {
        WriteLine("cATEGORIES AND HOW MANY ProductS THEY HAVE");
        IQueryable<Category> cats = db.Categories.Include(c=> c.Products);
        WriteLine(cats);
        foreach (Category c in cats)
        {
          WriteLine($"{c.CategoryName} has  {c.Products.Count} products");
        }
      }
    }
  }

}