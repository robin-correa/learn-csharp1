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

        // [Dates]

        Console.WriteLine("Dates(): ");
        var dateTime = new DateTime(2015, 1, 1);
        var now = DateTime.Now;
        Console.WriteLine("Now: " + now); // Now (Sample): 18/2/2023 16:28:59

        var today = DateTime.Today;
        Console.WriteLine("Today: " + today); // Today (Sample): 18/2/2023 16:28:59

        Console.WriteLine("Hour: " + now.Hour); // HH
        Console.WriteLine("Minute: " + now.Minute); // MM

        var tomorrow = now.AddDays(1); // Tomorrow
        var yesterday = now.AddDays(-1); // Yesterday

        Console.WriteLine("ToLongDateString: " + now.ToLongDateString()); // ToLongDateString: Saturday, 18 February 2023
        Console.WriteLine("ToShortDateString: " + now.ToShortDateString()); // ToShortDateString: 18/2/2023
        Console.WriteLine("ToLongTimeString: " + now.ToLongTimeString()); // ToLongTimeString: 16:33:18
        Console.WriteLine("ToShortTimeString: " + now.ToShortTimeString()); // ToShortTimeString: 16:33
        Console.WriteLine("ToString: " + now.ToString()); // ToString: 18/2/2023 16:35:01

        Console.WriteLine("ToString with Format specifier (yyyy-MM-dd HH:mm): " + now.ToString("yyyy-MM-dd HH:mm")); // ToString: 18/2/2023 16:35:01

        // [TimeSpan]

        // Creating
        var timeSpan = new TimeSpan(1, 2, 3); // 1 hour, 2 minutes, 3 seconds
        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;
        Console.WriteLine("Duration: " + duration);

        // Properties
        Console.WriteLine("Minutes: " + timeSpan.Minutes); // 2
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 62.05

        // Add
        Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // 01:10:03 (1 hour, 2 minutes, 3 seconds)
        Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // 01:10:03 (1 hour, 0 minutes, 3 seconds)

        // ToString
        Console.WriteLine("ToString: " + timeSpan.ToString()); // 01:02:03

        // Parse
        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // 01:02:03

        // [Strings]

        var fullName2 = "Robin Correa ";
        Console.WriteLine("Trim: '{0}'", fullName2.Trim()); // 'Robin Correa'
        Console.WriteLine("ToUpper: '{0}'", fullName2.Trim().ToUpper()); //'ROBIN CORREA'

        var index2 = fullName2.IndexOf(' ');
        var firstName2 = fullName2.Substring(0, index2); // from 0 to indexof " "
        var lastName2 = fullName2.Substring(index2 + 1); // from indexof onwards
        Console.WriteLine("FirstName: " + firstName2); // Robin
        Console.WriteLine("LastName: " + lastName2); // Correa

        var names2 = fullName2.Split(' ');
        Console.WriteLine("FirstName: " + names2[0]); // Robin
        Console.WriteLine("LastName: " + names2[1]); // Correa

        Console.WriteLine(fullName2.Replace("Robin", "RJ")); // RJ Correa

        // White space will treat as non-null or non-empty. Need to add Trim()
        if (String.IsNullOrEmpty(" ".Trim()))
        {
            Console.WriteLine("IsNullOrEmpty: Invalid");
        }

        if (String.IsNullOrWhiteSpace(" "))
        {
            Console.WriteLine("IsNullOrWhiteSpace: Invalid");
        }

        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age); // 25

        float price = 29.95f;
        Console.WriteLine(price.ToString("C")); // $29.95
        Console.WriteLine(price.ToString("C0")); // $30

        // Summarizing Text
        var sentence = "The quick brown fox jumps over the lazy dog.";

        var summary = StringUtility.SummarizeText(sentence);
        Console.WriteLine(summary);

        // String Builder (Note: No searching, functions can be chained .Append().AppendLine())
        Console.WriteLine("String Builder: ");
        var builder = new System.Text.StringBuilder();
        builder.Append('-', 10);
        builder.AppendLine();
        builder.Append("Header");
        builder.AppendLine();
        builder.Append('-', 10);
        Console.WriteLine(builder);

        /* Result: 
            ----------
            Header
            ----------
        */

        builder.Replace('-', '+');
        Console.WriteLine(builder);

        /* Result: 
            ++++++++++
            Header
            ++++++++++
        */
        builder.Remove(0, 10);
        Console.WriteLine(builder);

        /* Result: 
            Header
            ++++++++++
        */

        // File and FileInfo classes

        var path1 = @"c:\somefile.jpg";
        File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
        File.Delete(path1);
        if (File.Exists(path1))
        {
            //
        }

        var content = File.ReadAllText(path1);

        var fileInfo = new FileInfo(path1);
        fileInfo.CopyTo("...");
        fileInfo.Delete();

        if (fileInfo.Exists)
        {
            //
        }

        // Path class
        var path2 = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.cs";
        var dotIndex = path2.IndexOf('.');
        var extension = path2.Substring(dotIndex);
        Console.WriteLine("Extension: " + Path.GetExtension(path2)); // .cs
        Console.WriteLine("File Name: " + Path.GetFileName(path2)); // HelloWorld.cs
        Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path2)); // HelloWorld
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path2)); // C:\Projects\CSharpFundamentals\HelloWorld

    }
}