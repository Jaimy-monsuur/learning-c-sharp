using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            double Numbertotal = 0, count = 0;
            double Average = 0;

            Console.Write("Enter a number: ");

            // read value
            double value = double.Parse(Console.ReadLine());

            //While loop that stops at 0
            while (value != 0) 
            {
                Console.Write("Enter a number: ");
                if (value > 0)
                {
                    Numbertotal = Numbertotal + value;
                    count++;
                }

                // read next value
                value = int.Parse(Console.ReadLine());
            }

            if (Numbertotal > 0)
            {
                Average = Numbertotal / count;
            }
            else
            {
                Average = 0;
            }
            Console.WriteLine("Average of all positive numbers is: {0:N2}", Average);

            Console.ReadKey();
        }
    }
}
