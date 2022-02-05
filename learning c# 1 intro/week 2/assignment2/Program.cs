using System;
using System.Globalization;
using System.Threading;


namespace opdracht_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //ask for the numbers
            Console.Write("Enter 1st number: ");
            string Input1 = Console.ReadLine();

            Console.Write("Enter 2st number: ");
            string Input2 = Console.ReadLine();

            Console.Write("Enter 3st number: ");
            string Input3 = Console.ReadLine();

            //omzetten naar double
            double number1 = double.Parse(Input1);
            double number2 = double.Parse(Input2);
            double number3 = double.Parse(Input3);

            Double sum = number1 + number2 + number3;

            double average = sum / 3.00; // want is beter
            // the average is:
            Console.WriteLine($"The average is: {average} ");

            Console.ReadKey();
        }
    }
}
