using System;
using System.Diagnostics;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vraag en zet antwoord om naar input
            Console.WriteLine("Enter a number 1..4");
            string input = Console.ReadLine();

            //gebruik een switch
            switch (input)
            {
                case "1":
                    Console.WriteLine("Clubs");
                    break;
                case "2":
                    Console.WriteLine("Diamonds");
                    break;
                case "3":
                    Console.WriteLine("Hearts");
                    break;
                case "4":
                    Console.WriteLine("Spades");
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;

            }

            Console.ReadKey();

        }
    }
}
