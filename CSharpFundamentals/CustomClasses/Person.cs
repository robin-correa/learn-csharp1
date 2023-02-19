
namespace CSharpFundamentals.CustomClasses;
public class Person
{
    public string? FirstName; // Nullable type
    public string? LastName; // Nullable type

    public void Introduce()
    {
        Console.WriteLine("My name is " + FirstName + " " + LastName);
    }
}