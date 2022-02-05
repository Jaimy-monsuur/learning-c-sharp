using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                int NrDelers = TelDelers(i);
                if (NrDelers >= 10)
                {
                    Console.WriteLine($"{i}: {NrDelers}");
                }
            }

            Console.WriteLine("einde programma");
            Console.ReadKey();
        }

        static int TelDelers(int getal)
        {
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (getal % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
