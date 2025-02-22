# Learning C# Fundamentals (Part 1)

## 1. Non-primitive Types

- Classes
- Arrays
- Strings
- Enums
- Reference Types and Value Types

## 2. Control Flow - Loops

- For Loop
- Foreach Loop
- While Loop

## 3. Arrays and Lists

### Arrays

```cs
var numbers3 = new[] { 3, 7, 9, 2, 14, 6 };
```

- Length
- IndexOf()
- Clear()
- Copy()
- Sort()
- Reverse()

### Lists

```cs
var numbers4 = new List<int>() { 1, 2, 34, 4 };
```

- Add()
- AddRange()
- IndexOf()
- LastIndexOf()
- .Count
- Remove()
- Clear()

## 4. Working with Dates

### DateTime

```cs
var dateTime = new DateTime(2015, 1, 1);
var now = DateTime.Now; // // Now (Sample): 18/2/2023 16:28:59
var today = DateTime.Today;

var tomorrow = now.AddDays(1); // Tomorrow
var yesterday = now.AddDays(-1); // Yesterday

var ToLongDateString = now.ToLongDateString(); // Saturday, 18 February 2023
var toShortDateString = now.ToShortDateString(); // 18/2/2023
var toLongTimeString = now.ToLongTimeString(); // 16:33:18
var toShortTimeString  =now.ToShortTimeString(); // 16:33
var toString =  now.ToString(); // 18/2/2023 16:35:01

var toStringWithFormatter = now.ToString("yyyy-MM-dd HH:mm"); // 18/2/2023 16:35:01
```

### TimeSpan

```cs
var timeSpan = new TimeSpan(1, 2, 3); // 1 hour, 2 minutes, 3 seconds
var timeSpan1 = new TimeSpan(1, 0, 0);
var timeSpan2 = TimeSpan.FromHours(1);
```

## 5. Working with Strings

```cs
var fullName2 = "Robin Correa ";
Console.WriteLine("Trim: '{0}'", fullName2.Trim()); // 'Robin Correa'
Console.WriteLine("ToUpper: '{0}'", fullName2.Trim().ToUpper()); //'ROBIN CORREA'

var index2 = fullName2.IndexOf(' ');
var firstName2 = fullName2.Substring(0, index2); // from 0 to indexof " "
var lastName2 = fullName2.Substring(index2 + 1); // from indexof onwards
Console.WriteLine("FirstName: " + firstName2); // Robin
```

## 6. Working with Files

### File and FileInfo classes

```cs
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
```

### Path class

```cs
var path2 = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.cs";
var dotIndex = path2.IndexOf('.');
var extension = path2.Substring(dotIndex);
Console.WriteLine("Extension: " + Path.GetExtension(path2)); // .cs
Console.WriteLine("File Name: " + Path.GetFileName(path2)); // HelloWorld.cs
Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path2)); // HelloWorld
Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path2)); // C:\Projects\CSharpFundamentals\HelloWorld
```
