using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] countriesOne = { "Ukraine", "Poland", "Germany", "France", "Italy", "Ukraine" };
        string[] countriesTwo= { "Germany", "France", "Spain", "Poland", "Portugal" };

        var minus = countriesOne.Except(countriesTwo);
        Console.WriteLine(string.Join(", ", minus));

        var plus = countriesOne.Intersect(countriesTwo);
        Console.WriteLine(string.Join(", ", plus));

        var sum = countriesOne.Union(countriesTwo);
        Console.WriteLine(string.Join(", ", sum));

        var firstArray = countriesOne.Distinct();
        Console.WriteLine(string.Join(", ", firstArray));
    }
}
