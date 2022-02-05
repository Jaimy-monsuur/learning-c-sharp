using System;
using CandyCrushLogic;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nrOfRows> <nrOfColumns>");
                return;
            }
            int nrOfRows = int.Parse(args[0]);
            int nrOfColumns = int.Parse(args[1]);

            Program myProgram = new Program();
            myProgram.Start(nrOfRows, nrOfColumns);
        }
        void Start(int nrOfRows, int nrOfColumns)
        {
            RegularCandies[,] playingField = new RegularCandies[nrOfRows, nrOfColumns];
            InitCandies(playingField);
            DisplayCandies(playingField);;

           bool scoreR = CandyCrusher.ScoreRowPresent(playingField);
            bool scoreC = CandyCrusher.ScoreColumPresent(playingField);

            if (scoreR == true)
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }

            if (scoreC == true)
            {
                Console.WriteLine("column score");
            }
            else
            {
                Console.WriteLine("no column score");
            }

            Console.ReadKey();
        }

        void InitCandies(RegularCandies[,] playingField)
        {
            Random rnd = new Random();
            for (int nrOfRows = 0; nrOfRows < playingField.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < playingField.GetLength(1); nrOfColumns++)
                {
                    playingField[nrOfRows, nrOfColumns] = (RegularCandies)(int)(RegularCandies)rnd.Next(0, 6);
                }
            }

        }
        void DisplayCandies(RegularCandies[,] playingField)
        {
            for (int nrOfRows = 0; nrOfRows < playingField.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < playingField.GetLength(1); nrOfColumns++)
                {
                    switch ((int)playingField[nrOfRows, nrOfColumns])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                    }
                    Console.Write("# ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

    }
}
