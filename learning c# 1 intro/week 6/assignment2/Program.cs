using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number (0 is stop value): ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else if (IsPrimeNumber(number))
                {
                    Console.WriteLine("{0} is a prime number.", number);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", number);
                }
                //herhaal
                Console.Write("Enter number (0 is stop value): ");
                number = int.Parse(Console.ReadLine());
            }

            if (number == 0)
            {
                Console.Write("end of program");
            }

        }


        static bool IsPrimeNumber (int number)
        {
            if (number < 2) return false;

            bool isPrime = true;


            int i = 2;
            while ((i < number) && (isPrime))
            {
                if ((number % i) == 0)
                    isPrime = false;
                else
                    i++;
            }
            return isPrime;
        }
    }
    
}
