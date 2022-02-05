using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Console.Write("geef een zin: ");
            string zin = Console.ReadLine();
            string nieuwezin = HusselZinWoorden(zin);
            Console.WriteLine($"Nieuwe zin is: {nieuwezin}");
        }
        string HusselZinWoorden(string zin)
        {
            string Newstring = null;
            string[] woorden = zin.Split(' ');
            foreach (string woord in woorden)
            {
                Newstring += HusselWoord(woord);
                Newstring += " ";
            }
            return Newstring;
        }
        string HusselWoord(string woord)
        {
            Random rnd = new Random();
            int number;
            string NewWoord = woord[0].ToString();
            string restwoord = woord.Substring(1, woord.Length - 2);
            if (woord.Length <= 3)
            {
                NewWoord = woord;
            }
            else
            {
                while (restwoord != "")
                {
                    number = rnd.Next(0, restwoord.Length);
                    NewWoord += restwoord[number];
                    restwoord = restwoord.Remove(number, 1);//hoe werkt deze
                }
                NewWoord += woord[woord.Length -1];
            }

            return NewWoord;
        }
    }

}