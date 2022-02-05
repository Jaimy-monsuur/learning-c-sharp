using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask name 
            Console.WriteLine("Enter your age:");
            // variabele name
            string name;
            name = Console.ReadLine();
            //Ask age
            Console.WriteLine("Enter your age:");
            //variabele age
            string age = Console.ReadLine();
            //display name and age
            Console.Write("Your name is " + name);
            Console.Write("Your age is " + age);
        }

    }
}
