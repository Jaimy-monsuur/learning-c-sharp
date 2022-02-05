using System;

namespace Opgave3
{
    class Program
    {
        const int SIZE = 20;
        static void Main(string[] args)
        {
            int[] Numbers = new int[SIZE];
            Random rnd = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                Numbers[i] = rnd.Next(1, 100);
            }

            Console.Write("Voer een getal in: ");
            int Getal = int.Parse(Console.ReadLine());

            for (int i = 0; i < Numbers.Length; i++)
            {
                if ((Numbers[i] >= Getal - 10) && (Numbers[i] <= Getal + 10))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if ((Numbers[i] >= Getal - 20) && (Numbers[i] <= Getal + 20))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write(Numbers[i] + " ");
                Console.ResetColor();

            }
            Console.ReadKey();
        }
    }
}
