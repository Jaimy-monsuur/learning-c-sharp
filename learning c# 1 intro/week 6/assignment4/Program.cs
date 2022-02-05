using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text>");
            string text = Console.ReadLine();
            searchtext(text);
        }
        static void searchtext(string text)
        {
            //declaring stuff
            int nrOfCommas = 0;
            int nrOfFullStops = 0;
            int nrOfSemiColons = 0;

            foreach (char c in text)
            {
                switch (c)
                {
                    case '.':
                        nrOfFullStops++;
                        break;
                    case ',':
                        nrOfCommas++;
                        break;
                    case ';':
                        nrOfSemiColons++;
                        break;
                    default:
                        break;
                }
            }

            Console.Write($"result:{nrOfFullStops} full stops, {nrOfCommas} commas, {nrOfSemiColons} semicolons");
                Console.ReadKey();
            
        }
    }
}
