class Program
{
    public class Person
    {
        public string? FirstName; // Nullable type
        public string? LastName; // Nullable type

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    static void Main(string[] args)
    {
        var person1 = new Person();
        person1.FirstName = "Robin";
        person1.LastName = "Correa";
        person1.Introduce();
    }
}