using System;

namespace opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //read number
            Console.Write("enter a number: ");
            string imput = Console.ReadLine();
            int number = int.Parse(imput);

            // assign result
            int result = number + number;

            //aad 10 to result
            result = result + 10;

            //Divide by 10
            result = result / 2;

            //substract 
            result = result - number;

            //show result
            Console.WriteLine($"result is {result}");
        }
    }
}
