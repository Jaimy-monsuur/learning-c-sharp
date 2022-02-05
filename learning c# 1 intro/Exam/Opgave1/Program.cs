using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer je naam in: ");
            string Naam = Console.ReadLine();
            Console.Write("Voer je geboorte jaar in: ");
            int GbJaar = int.Parse(Console.ReadLine());
            Console.Write("Voer je leeftijd in: ");
            int Leetfijd = int.Parse(Console.ReadLine());

            int HuidigJaar = DateTime.Now.Year;
            if (HuidigJaar - Leetfijd == GbJaar)
            {
                Console.WriteLine($"Hoi {Naam}, je bent al jarig geweest dit jaar!");
            }
            else if (HuidigJaar - Leetfijd == GbJaar + 1)
            {
                Console.WriteLine($"Hoi {Naam}, je bent nog niet jarig geweest dit jaar!");
            }
            else
            {
                Console.WriteLine($"Hoi {Naam}, de ingevoerde leeftijd of geboortejaar is niet correct!");
            }
            Console.ReadKey();
        }
    }
}
