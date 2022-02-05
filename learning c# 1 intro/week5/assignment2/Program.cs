using System;

namespace assignment2
{
    class Program
    {
        const int ARAYSIZE = 20;
        const int MAX_NUMBER = 150;
        static void Main(string[] args)
        {
            //declaring stuff
            int[] Numbers = new int[ARAYSIZE];
            int SmalestNumber = 150;
            int Occurence = 0;

            //random getallen genereeren.
            Random Random = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Random.Next(0, MAX_NUMBER);
                
                Console.WriteLine($"Element {i} = {Numbers[i]}");// bij opdracht 1 had ik dit anders gedaan maar dit is een stuk makkelijker en minder werk.
            }

            foreach (int Number in Numbers)
            {
                if (Number < SmalestNumber)
                {
                    SmalestNumber = Number;
                    Occurence = 1;
                }
                else if (SmalestNumber == Number)
                {
                    Occurence++;
                }
            }

            Console.WriteLine($"smallest number = {SmalestNumber}");
            Console.WriteLine($"number of occurence = {Occurence}");
        }

    }
}
