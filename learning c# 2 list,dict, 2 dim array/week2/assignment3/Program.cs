using System;

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

            bool ScoreRow = ScoreRowPresent(playingField);
            bool ScoreCol = ScoreColumPresent(playingField);

            if (ScoreRow == true)
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }

            if (ScoreCol == true)
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
        bool ScoreRowPresent(RegularCandies[,] playingField)
        {
            bool score = false;
            int count = 1;
            for (int nrOfRows = 0; nrOfRows < playingField.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < playingField.GetLength(1); nrOfColumns++)
                {
                    RegularCandies currentCandy = playingField[nrOfRows, nrOfColumns];
                    RegularCandies nextCandy = playingField[nrOfRows, nrOfColumns];

                    if (currentCandy == nextCandy)
                    {
                        count++;
                        if (nrOfColumns >= 1)
                        {
                            RegularCandies previousCandy = playingField[nrOfRows, nrOfColumns - 1];
                            if (previousCandy == currentCandy)
                            {
                                count++;
                                if (count == 3)
                                {
                                    score = true;
                                    break;
                                }
                                else
                                {

                                    count = 1;
                                }
                            }
                        }

                    }
                }
            }
            return score;
        }

        bool ScoreColumPresent(RegularCandies[,] playingField)
        {
            bool score = false;
            int count = 1;
            for (int nrOfRows = 0; nrOfRows < playingField.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < playingField.GetLength(1); nrOfColumns++)
                {
                    RegularCandies currentCandy = playingField[nrOfRows, nrOfColumns];

                    if (nrOfRows >= 2)
                    {
                        RegularCandies previousCandy = playingField[nrOfRows - 1, nrOfColumns];
                        if (previousCandy == currentCandy)
                        {
                            count++;
                            previousCandy = playingField[nrOfRows - 2, nrOfColumns];
                            if (previousCandy == currentCandy)
                            {
                                count++;
                                if (count == 3)
                                {
                                    score = true;
                                    break;
                                }
                            }
                           
                        }
                        else
                        {

                            count = 1;
                        }
                    }


                }
            }
            return score;
        }

    }
}
