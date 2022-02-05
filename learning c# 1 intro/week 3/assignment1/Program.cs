using System;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int low;
            int high;

            // read input number 1 and 2
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            //Convert to int
            int getal1 = int.Parse(input1);
            int getal2 = int.Parse(input2);

            //witregel
            Console.WriteLine();

            //if else
            if (getal1 > getal2)
            {
                low = getal2;
                high = getal1;
            }
            else
            {
                low = getal1;
                high = getal2;
            }

            Console.WriteLine($"highest value is: {high} ");
            Console.WriteLine($"lowest value is: {low} ");

            Console.ReadKey();


        }
    }
}
