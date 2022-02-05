using System;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i <= number / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("!");
                    }
                }
                Console.Write("\nGeef een getal: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ende programma");
            Console.ReadKey();
        }
    }
}
