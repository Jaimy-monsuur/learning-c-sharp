using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a year: ");

            // read year
            double year = double.Parse(Console.ReadLine());

            //While loop that stops at 0
            while (year != 0)
            {
                if (year < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else
                {
                    if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    {
                        Console.WriteLine("{0} is a leap year.", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year.", year);
                    }
                }
               

                // read next year
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
