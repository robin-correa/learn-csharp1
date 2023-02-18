using CSharpFundamentals.CustomClasses; // for Person class

namespace CSharpFundamentals;

// Usage of enum:
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}

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

        // [Strings]

        var firstName = "Robin";
        var lastName = "Correa";

        var fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);  // Robin Correa
        var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
        Console.WriteLine(myFullName);  // My name is Robin Correa

        var formattedNames = string.Join(", ", names);

        Console.WriteLine(formattedNames); // Robin, Regina, Jean

        // Verbatim string
        var text = @"Hi Robin, 
        Look into the following paths:
        c:\folder1\
        c:\folder2\
        c:\folder3\";

        Console.WriteLine(text);

        // [Enums]
        var method = ShippingMethod.Express;
        Console.WriteLine(method); // Express
        Console.WriteLine((int)method); // 3

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId); // Express

        Console.WriteLine(method.ToString()); // Express

        var methodName = "Express";
        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        Console.WriteLine(shippingMethod); // Express

        // [Reference Types and Value Types]

        // Value Types
        var a = 10;
        var b = a;
        b++; // 10

        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 11

        // Reference Types

        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;

        Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // array1[0]: 0, array2[0]: 0

        // [For loops]

        // Ascending
        for (var i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i); // 2 4 6 8 10
            }
        }

        // Descending
        for (var i = 10; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i); // 10 8 6 4 2
            }
        }

        // [Foreach loop]
        var name = "Robin";
        foreach (var character in name)
        {
            Console.WriteLine(character); // R o b i n
        }

        var numbers2 = new int[] { 1, 2, 3, 4 };
        foreach (var number in numbers2)
        {
            Console.WriteLine(number); // 1, 2, 3, 4
        }

        // [While loop]
        while (true)
        {
            Console.Write("Type your name: ");
            var input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("@Echo: " + input);
                continue;
            }

            break;
        }

        // [Arrays]

        var numbers3 = new[] { 3, 7, 9, 2, 14, 6 };

        // Length
        Console.WriteLine("Length: " + numbers3.Length); // Length: 6

        // IndexOf()
        var index = Array.IndexOf(numbers3, 9);
        Console.WriteLine("IndexOf(): " + index); // Index: 2

        // Clear() - setting the first 2 elements to 0 (Result: 0 0 9 2 14 6)
        Console.WriteLine("Clear(): ");
        Array.Clear(numbers3, 0, 2);
        foreach (var n in numbers3)
        {
            Console.WriteLine(n);
        }

        // Copy()
        int[] another = new int[3];
        Array.Copy(numbers3, another, 3); // Result: 0 0 9
        Console.WriteLine("Copy(): ");
        foreach (var n in another)
        {
            Console.WriteLine(n);
        }

        // Sort()
        Console.WriteLine("Sort(): ");
        Array.Sort(numbers3); // 0 0 2 6 9 14
        foreach (var n in numbers3)
        {
            Console.WriteLine(n);
        }

        // Reverse()
        Console.WriteLine("Reverse(): ");
        Array.Reverse(numbers3); // 14 9 6 2 0 0
        foreach (var n in numbers3)
        {
            Console.WriteLine(n);
        }

        // [Lists]
        Console.WriteLine("Lists(): ");
        var numbers4 = new List<int>() { 1, 2, 34, 4 };
        numbers4.Add(1); // 1 2 34 4 1
        numbers4.AddRange(new int[3] { 5, 6, 7 }); // 1 2 34 4 1 5 6 7
        foreach (var number in numbers4)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Index of 1: " + numbers4.IndexOf(1)); // 0
        Console.WriteLine("Last Index of 1: " + numbers4.LastIndexOf(1)); // 4

        Console.WriteLine("Count: " + numbers4.Count); // 8

        Console.WriteLine("Remove(): ");
        for (var i = 0; i < numbers4.Count; i++)
        {
            if (numbers4[i] == 1)
            {
                numbers4.Remove(numbers4[i]);
            }
        }

        foreach (var number in numbers4)
        {
            Console.WriteLine(number);
        }

        // Result: 2, 34, 4, 5, 6, 7

        Console.WriteLine("Clear(): ");
        numbers4.Clear();
        Console.WriteLine("Count: " + numbers4.Count); // 0
    }

}