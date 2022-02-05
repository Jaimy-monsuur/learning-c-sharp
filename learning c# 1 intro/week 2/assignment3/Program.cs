using System;
using System.Globalization;
using System.Threading;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            string invoer = Console.ReadLine();

            // geef seconden
            int seconden = Int32.Parse(invoer);

            // aantal uuren
            int uren = seconden / 3600;

            // bereken overige seconde
            seconden = seconden - uren * 3600;  // = seconden % 3600;

            // aantal minuten
            int minuten = seconden / 60;

            // bepaal overige seconden
            seconden = seconden - minuten * 60; // = seconden % 60;

            // geen tijd weer
            Console.WriteLine("{0:00}:{1:00}:{2:00}", uren, minuten, seconden);

            Console.ReadKey();
        }
    }
}

