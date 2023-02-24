// See https://aka.ms/new-console-template for more information
namespace CSHowickDev
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "hey" + ", My name is ";

            string personName = "Bally";

            char[] charsArr = { 'A', 'B', 'Z' };

            string[] textsArr = {"name", "age", "position"};


            Console.WriteLine(personName.Substring(2).ToUpper());

            Console.WriteLine(charsArr.Length);

            Console.WriteLine("Welcome, please Authenticate yourself below:");

            Console.Write("Name:");

            string name = Console.ReadLine();
            Console.Write("Password:");

            string password = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ", your password is " + password);

            Console.WriteLine("This is strictly for 18+, please enter your age below");

            Console.Write("Age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Your age is " + age);


            Console.ReadLine();
        }
    }
}