using System;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //read age of user
            Console.Write("Enter your name: ");
            String input = Console.ReadLine();

            //Convert string to int
            int age = int.Parse(input);

            age = age + 1;
            
            //convert int to text
            string output = age.ToString();

            //display incresed age
            Console.WriteLine("Next year you will be " + age + " years old.");

            // enter key
            Console.ReadKey();
        }
    }
}
