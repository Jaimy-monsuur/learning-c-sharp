using System;
using System.Threading;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {

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


            if (getal1 > getal2 && getal2 > getal3)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else  
            {
                Console.WriteLine("The third number is the not smallest of the three");
            }


            Console.ReadKey();
        }
    }
}
