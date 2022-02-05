using System;
using System.Collections.Generic;
using System.IO;

namespace opdracht3
{
    class Program
    {
        // Basic code
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
            List<Stelling> stellingen = LeesStellingen("stellingen.txt");
            List<Partij> Partijen = LeesPartijen("partijen.txt");
            if (stellingen == null || Partijen == null)
            {
                Console.WriteLine("end of program");
            }
            else
            {
                string antwoorden = DoorloopStellingen(stellingen);
                VergelijkPartijen(antwoorden, Partijen);
                Console.WriteLine("\nend of program");
            }
        }

        List<Stelling> LeesStellingen(string bestand)
        {
            List<Stelling> stellingen = new List<Stelling>();
            
            StreamReader reader = new StreamReader(bestand);
            while (!reader.EndOfStream)
            {
                Stelling stelling = new Stelling();
                stelling.titel = reader.ReadLine();
                stelling.tekst = reader.ReadLine();

                stellingen.Add(stelling);
            }
            reader.Close();
            return stellingen;
        }

        List<Partij> LeesPartijen(string bestand)
        {
            List<Partij> partijen = new List<Partij>();
            StreamReader reader = new StreamReader(bestand);

            while (!reader.EndOfStream)
            {
                Partij partij = new Partij();
                partij.naam = reader.ReadLine();
                partij.antwoord = reader.ReadLine();

                partijen.Add(partij);
            }
            reader.Close();
            return partijen;
        }

        string DoorloopStellingen(List<Stelling> stellingen)
        {
            int count = 1;
            string antwoorden = "";
            foreach (Stelling stelling in stellingen)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(count + ". " + stelling.titel);
                Console.ResetColor();
                Console.WriteLine(stelling.tekst);
                Console.Write("\nGeef uw mening (1=eens, 2=oneens, 3=geen): ");
                string awnser = Console.ReadLine();
                Console.WriteLine();
                antwoorden += awnser;
                count++;
            }
            return antwoorden;
        }

        double BepaalMatchPercentage(string gebruiker,Partij partij)
        {
            // compare all answers (user and party)
            int points = 0;
            for (int i = 0; i < gebruiker.Length; i++)
            {
                if (partij.antwoord[i] == gebruiker[i])
                {
                    points++;
                }
            }
            return (points / (double)gebruiker.Length) * 100;
        }

        void VergelijkPartijen(string gebruiker, List<Partij> partijen)
        {
            foreach (Partij Partij in partijen)
            {
                double P = BepaalMatchPercentage(gebruiker, Partij);
                Console.WriteLine($"{Partij.naam:0, -5} : {P:0.00} %");
            }
        }
    }
}
