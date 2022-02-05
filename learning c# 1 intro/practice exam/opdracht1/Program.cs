using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring stuff
            string Reverseword = string.Empty;

            Console.Write("Geef een woord: ");
            string word = Console.ReadLine();

            foreach (char c in word)
            {
                Reverseword = c + Reverseword;
            }

            
            if (word == Reverseword)
            {
                Console.WriteLine($"{word} is een palidroom.");
            }
            else
            {
                Console.WriteLine($"{word} is geen palidroom.");
            }
            Console.ReadKey();

        }
    }
}
