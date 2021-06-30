using System;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rohan To C# World!");

            string firstName, lastName;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Your full name is " + firstName + " " + lastName);
        }
    }
}
