using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring stuff
            double count = 0, Numbertotal = 0;

            Console.Write("Enter a number: ");

            // read value
            double value = double.Parse(Console.ReadLine());

            //While loop that stops at 0
            while (value != 0)
            {
                Console.Write("Enter a number: ");
                if (value > 0)
                {
                    if (count < 4)
                    {
                        count++;
                    }
                    else
                    {
                        Numbertotal = Numbertotal + value;
                        count = 0;
                    }
                }

                // read next value
                value = int.Parse(Console.ReadLine());
            }

            //Average 5th, 10th, 15th, ... number

            Console.WriteLine("Sum of 5th, 10th, 15th, ... number is: "+ Numbertotal);

            Console.ReadKey();
        }
    }
}
