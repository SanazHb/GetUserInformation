using System;

namespace GetInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, age;
            Console.WriteLine("Hello\nComplete your information.");
            Console.WriteLine("Enter your first name please:");
            firstName = Console.ReadLine();
            while(string.IsNullOrEmpty(firstName) == true)
            {
                Console.WriteLine("Enter your first name please:");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Enter your last name please:");
            lastName = Console.ReadLine();
            while(string.IsNullOrEmpty(lastName) == true)
            {
                Console.WriteLine("Enter your last name please:");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("Enter your age please:");
            age = Console.ReadLine();
            while(string.IsNullOrEmpty(age) == true)
            {
                Console.WriteLine("Enter your age please:");
                age = Console.ReadLine();
            }
            Console.WriteLine("These are your information:\n"+firstName+" "+lastName+"\nAge: "+age);
            Console.ReadLine();
        }
    }
}
