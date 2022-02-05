using System;

namespace assignment4
{
    class Program
    {
        const int MAX_NUMBERS = 20;
        static void Main(string[] args)
        {
            //is een lastige opdracht.
            //declaring stuff
            int[] Numbers = new int[MAX_NUMBERS];
            int nrOfElements = 0;
            int Number;
            int occurance = 0;

            //ask and declare input
            Console.Write("Enter a number (0=stop): ");
            Number = int.Parse(Console.ReadLine());

            //for loop (kan dit niet ook met een while loop????)

            while ((Number != 0) && (nrOfElements < MAX_NUMBERS))
            {
                Numbers[nrOfElements] = Number;
                nrOfElements++;

                //ask and declare input (repeat)
                Console.Write("\nEnter a number (0=stop): \n");
                Number = int.Parse(Console.ReadLine());
            }

            //witregel
            Console.WriteLine("");

            //ask the searchvalue
            Console.Write("Enter searchvalue: ");
            int SearchValue = int.Parse(Console.ReadLine());

            foreach (int NextNumber in Numbers)
            {
                if (NextNumber == SearchValue)
                {
                    occurance++;
                }
            }
            Console.WriteLine($"\nNumber of occurences of searchvalue ({SearchValue}) is: {occurance}");
        }
    }
}
