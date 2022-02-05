using System;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //read name of user
            Console.Write("Enter your first name: ");
            String firstname = Console.ReadLine();

            //Read last name of user
            Console.Write("Enter your last name: ");
            String lastname = Console.ReadLine();

            //display full name 1
            Console.WriteLine("Your full name is " + firstname + " " + lastname);

            //display full name 2
            Console.WriteLine("Your full name is {0} {1}", firstname, lastname);

            //Display fullname 3
            Console.WriteLine($"Your full name is {firstname} {lastname}");

            //wait for the user to enter a key
            Console.ReadKey();
        }
    }
}
