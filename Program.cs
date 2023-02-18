using classes; // for Person class

class Program
{
    static void Main(string[] args)
    {
        // [Classes]
        var person1 = new Person();
        person1.FirstName = "Robin";
        person1.LastName = "Correa";
        person1.Introduce(); // My name is Robin Correa

        // [Arrays]

        // Array of integers
        var numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]); // 1
        Console.WriteLine(numbers[1]); // Default: 0
        Console.WriteLine(numbers[2]); // Default: 0

        // Array of booleans
        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]); // True
        Console.WriteLine(flags[1]); // Default: False
        Console.WriteLine(flags[2]); // Default: False

        // Array of strings
        var names = new string[3] { "Robin", "Regina", "Jean" };

        Console.WriteLine(names[0]); // Robin
        Console.WriteLine(names[1]); // Regina
        Console.WriteLine(names[2]); // Jean
        // Console.WriteLine(names[3]); // Unhandled Exception
    }
}