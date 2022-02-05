using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {

        const int ARAYSIZE = 20;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //declaring stuff
            int[] Numbers = new int[ARAYSIZE];
            double Totall = 0;
            int Element1 = 0;  

            //20 random  nummer tussen 0 en 200 en totaal uitrekenen
            Random Rnumbers = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Rnumbers.Next(201);
                Totall += Numbers[i];
            }

            // show elements(Heb 2 keer element gebruikt omdat hij anders bij 1 begon ipv 0.)
            for (int i = 0; i < Numbers.Length; i++)
            {
                int Element2 = Element1++;
                string RandomNumbers = Numbers[i].ToString();
                Console.WriteLine($"Element {Element2} is {RandomNumbers}");
            }
            // gemidelde uitrekenen
            double Average = Totall / Numbers.Length;
            Console.WriteLine($"The average is: {Average}");

            for (int i = 0; i < Numbers.Length; i++)//loop omdat je de array voledig moet uitlezen kan volgens mij niet zonder een loop.
            {
                // Difference moet altijd positief zijn!!// is dus een functie voor math.abs
                double difference = Math.Abs(Numbers[i] - Average);
                Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");//format kan ook zo aangegeven worden.onthouden!!!
            }


        }
    }
}
