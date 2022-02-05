using System;
using System.Globalization;
using System.Threading;

namespace opdracht4
{
    class Program
    {
        static double high;
        static double low;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;



            // read input number 1 and 2
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter third number: ");
            string input3 = Console.ReadLine();

            //naar double
            double getal1 = double.Parse(input1);
            double getal2 = double.Parse(input2);
            double getal3 = double.Parse(input3);

            //sum, averege and product
            double sum = getal1 + getal2 + getal3;
            double daverage = (getal1 + getal2 + getal3) / 3 ;
            double product = getal1 * getal2 * getal3;

            string average = daverage.ToString("0.00");

            //highest
            if ((getal1 > getal2) && getal1 > getal3)
            {
                high = getal1;
            }
            else if ((getal2 > getal1) && getal2 > getal3)
            {
                high = getal2;
            }
            else if ((getal3 > getal1) && getal3 > getal2)
            {
                high = getal3;
            }

            //lowest
            if ((getal1 < getal2) && getal1 < getal3)
            {
                low = getal1;
            }
            else if ((getal2 < getal1) && getal2 < getal3)
            {
                low = getal2;
            }
            else if ((getal3 < getal1) && getal3 < getal2)
            {
                low = getal3;
            }

            Console.WriteLine("sum = " + sum);
            Console.WriteLine("averege = " + average);
            Console.WriteLine("product = " + product);
            Console.WriteLine("highest = " + high);
            Console.WriteLine("lowest = " + low);


            Console.ReadKey();

        }
    }
}
