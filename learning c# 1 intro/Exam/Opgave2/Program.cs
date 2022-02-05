using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Value = 0;
            Console.Write("Voer een woord in: ");
            string woord = Console.ReadLine();

            while (woord != "stop")
            {
                foreach (char letter in woord)
                {
                    Value = letter;
                    Console.Write($"{letter}={Value} ");
                }
                Console.Write("\n\nVoer een woord in: ");
                woord = Console.ReadLine();
            }
            Console.WriteLine("\neinde programma");
            Console.ReadKey();
        }
    }
}
