using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //int[] array = { 1, 2, 3, 5324, 324, 4123, 534, 634, 23523, 754632, 3, 5, 67 };

        //var all = array.Select(n => n);
        //Console.WriteLine(string.Join(", ", all));

        //var pair = array.Where(n => n % 2 == 0);
        //Console.WriteLine(string.Join(", ", pair));

        //var notpair = array.Where(n => n % 2 != 0);
        //Console.WriteLine(string.Join(", ", notpair));

        //Console.WriteLine("Write number: ");
        //int numberUser = Convert.ToInt32(Console.ReadLine());
        //var biggerThan = array.Where(n => n > numberUser);
        //Console.WriteLine(string.Join(", ", biggerThan));

        //Console.WriteLine("Write diapozone: ");
        //int numberMin = Convert.ToInt32(Console.ReadLine());
        //int numberMax = Convert.ToInt32(Console.ReadLine());
        //var numberInDiapozone = array.Where(n => n <= numberMax && n >= numberMin);
        //Console.WriteLine(string.Join(", ", numberInDiapozone));

        //var seven = array.Where(n => n % 7 == 0).OrderBy(n => n);
        //Console.WriteLine(string.Join(", ", seven));

        //var eight = array.Where(n => n % 8 == 0).OrderByDescending(n => n);
        //Console.WriteLine(string.Join(", ", eight));

        //string[] cities =
        //{
        //    "Dnipro",
        //    "Kiev",
        //    "Krivoy Rog",
        //    "A",
        //    "KDFM",
        //    "NK",
        //    "Nerrrrr"
        //};

        //var allCities = cities.Select(city => city);
        //Console.WriteLine(string.Join(", ", allCities));
        //int len = 5;


        //var bigger = cities.Where(city => city.Length >= len);
        //Console.WriteLine(string.Join(", ", bigger));

        //var a = cities.Where(city => city.StartsWith("A"));
        //Console.WriteLine(string.Join(", ", a));

        //var m = cities.Where(city => city.EndsWith("M"));
        //Console.WriteLine(string.Join(", ", m));

        //var nk = cities.Where(city => city.StartsWith("N") && city.EndsWith("K"));
        //Console.WriteLine(string.Join(", ", nk));

        //var startWithNe = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city);
        //Console.WriteLine(string.Join(", ", startWithNe));

        Task[] students =
          {
            new Task("Boris", "Smith", 20, "MIT"),
            new Task("Anna", "Brown", 22, "Oxford"),
            new Task("Boris", "Brooks", 18, "Harvard"),
            new Task("John", "Brody", 21, "Oxford"),
            new Task("Emily", "Johnson", 23, "MIT"),
            new Task("Alice", "Brock", 19, "Cambridge"),
            new Task("Tom", "White", 24, "Oxford")
        };
        var allStudent = students.Select(s => s);
        foreach (var s in allStudent)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }

        var boris = students.Where(s => s.Name == "Boris");
        foreach (var s in boris)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }

        var bro = students.Where(s => s.Surname.StartsWith("Bro"));
        foreach (var s in bro)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }

        var bigger19 = students.Where(s => s.Age > 19);
        foreach (var s in bigger19)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }

        var inRange = students.Where(s => s.Age > 20 && s.Age < 23);
        foreach (var s in inRange)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }

        var mit = students.Where(s => s.University == "MIT");
        foreach (var s in mit)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }

        var oxford = students.Where(s => s.University == "Oxford" && s.Age > 18).OrderByDescending(s => s.Age);
        foreach (var s in oxford)
        {
            Console.WriteLine($"{s.Name} {s.Surname}, {s.Age} років, {s.University}");
        }
    }
}

class Task
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }

    public string University { get; set; }

    public Task (string Name, string Surname, int Age, string University)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age; 
        this.University = University;
    }
}
