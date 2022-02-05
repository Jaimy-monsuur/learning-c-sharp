using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring
            double count = 0;

            Console.Write("Enter Target number: ");

            // read value
            double target = double.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            double value = double.Parse(Console.ReadLine());

            //While loop that stops at 0
            while (value != 0)
            {
                Console.Write("Enter a number: ");
                if (value == target)
                {
                    count++;
                }
                // read next value
                value = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Count of numbers equal to target number: " + count);

            Console.ReadKey();
        }
    }
}
