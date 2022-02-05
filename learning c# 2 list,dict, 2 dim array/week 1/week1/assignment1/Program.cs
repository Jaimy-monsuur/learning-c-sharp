using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
           
            PrintMonth();
            Month Mo = ReadMonth("Enter a month number: ");
            Console.WriteLine((int)Mo + " => " + Mo);
            Console.ReadKey();
            
        }

        void PrintMonth(Month Mo)
        {
            if ((int)Mo < 10)
            {
                Console.WriteLine(" " + (int)Mo + ". " + Mo);
            }
            else
            {
                Console.WriteLine((int)Mo + ". " + Mo);
            }
            
        }

        void PrintMonth()
        {

            for (Month Mo = Month.January; Mo <= Month.December; Mo++)
            {
                PrintMonth(Mo);
            }

            Console.WriteLine();
        }

        Month ReadMonth(string question)
        {
            Console.Write(question);
            int Nr = int.Parse(Console.ReadLine());
            bool valid = false;
            for (int i = 0; !valid; i++)
            {
                if ((Nr < 1) || (Nr > 12))
                {
                    Console.WriteLine(Nr + " is not a valid value.");
                    Console.Write(question);
                    Nr = int.Parse(Console.ReadLine());
                }
                else
                {
                     valid = true;
                 }
             }
            Month Mo = (Month)Nr;
            return Mo;
        }
    }
}
