using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year (0 is stop value): ");
            int year = int.Parse(Console.ReadLine());

            while (year != 0)
            {
                if (year < 0)
                {
                    Console.WriteLine("Negative year entered...");
                }
                else if (IsleapYear(year))
                {
                    Console.WriteLine(year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year.");
                }
                //herhaal
                Console.Write("Enter year (0 is stop value): ");
                year = int.Parse(Console.ReadLine());
            }

            if (year == 0)
            {
                Console.Write("end of program");
            }

        }


        static bool IsleapYear(int year)
        {
            if (year < 0) return false;

            bool divideby400 = ((year % 400) == 0);
            bool divideby100 = ((year % 100) == 0);
            bool divideby4 = ((year % 4) == 0);

            return (divideby400 || (divideby4 && !divideby100));
        }
    }
}
