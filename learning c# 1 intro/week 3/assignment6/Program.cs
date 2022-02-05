using System;

namespace opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter score
            Console.Write("Enter your score");
            int score = int.Parse(Console.ReadLine());

            //determine grade
            if ((score >= 90) && score <= 100)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("course passed");
            }
            if ((score >= 80) && score <= 89)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("course passed");
            }
            if ((score >= 70) && score <= 79)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("course passed");
            }
            if ((score >= 60) && score <= 69)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("course not passed");
            }
            if ((score >= 0) && score <= 59)
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("course not passed");
            }

            Console.ReadKey();

        }
    }
}
