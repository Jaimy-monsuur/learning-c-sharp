using System;
using System.Threading;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring stuff
            int number1 = 1;
            int number2 = 1;
            int count = 2;

            Console.Write("{0}, {0}", number1, number2);

            while (count < 20)
            {
                int number3 = number1 + number2;
                Console.Write(", {0}", number3);

                number1 = number2;
                number2 = number3;

                count++;
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
