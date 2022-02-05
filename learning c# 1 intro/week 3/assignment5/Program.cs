using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input number 1 and 2
            Console.Write("Enter number 1: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter number 2: ");
            string input2 = Console.ReadLine();

            //naar double
            int getal1 = int.Parse(input1);
            int getal2 = int.Parse(input2);

            if (getal1 % getal2 == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (getal2 % getal1 == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }

            Console.ReadKey();

        }
    }
}
