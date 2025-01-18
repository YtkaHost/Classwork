using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Device[] devicesOne =
        {
            new Device { Name = "Phone", Creator = "Apple", Price = 999.99 },
            new Device { Name = "Tablet", Creator = "Samsung", Price = 500.50 },
            new Device { Name = "Laptop", Creator = "Lenovo", Price = 1111.11 }
        };

        Device[] devicesTwo =
        {
            new Device { Name = "Smartwatch", Creator = "Apple", Price = 0 },
            new Device { Name = "Monitor", Creator = "LG", Price = 12321 },
            new Device { Name = "Phone", Creator = "Huawei", Price = 3456.43 }
        };


        var first = devicesOne.Select(d => d.Creator);
        var second = devicesTwo.Select(d => d.Creator);

        var deviceMinus = first.Except(second);
        Console.WriteLine(string.Join(", ", deviceMinus));

        var devicePlus = first.Intersect(second);
        Console.WriteLine(string.Join(", ", devicePlus));

        var deviceSum = first.Union(second);
        Console.WriteLine(string.Join(", ", deviceSum));
    }
}

class Device
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public double Price { get; set; }

}