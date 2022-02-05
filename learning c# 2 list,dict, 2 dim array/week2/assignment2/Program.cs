using System;

namespace assignment2
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
            int[,] matrix = new int[nrOfRows, nrOfColumns];
            int min = 1;
            int max = 100;

            InitMatrixRandom(matrix, min, max);

            DisplayMatrix(matrix);

            Console.Write("\nEnter a number (to search for): ");
            int number = int.Parse(Console.ReadLine());

            Position Pos = SearchNumber(matrix, number);
            Console.WriteLine($"Number {number} is found (first) at position [{Pos.row},{Pos.colum}]");

            Position PosBackwards = SearchNumberBackwards(matrix, number);
            Console.WriteLine($"Number {number} is found (last) at position [{PosBackwards.row},{PosBackwards.colum}]");

            Console.ReadKey();
        }
        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    matrix[nrOfRows, nrOfColumns] = rnd.Next(min, max);
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    Console.Write("{0, 3}", matrix[nrOfRows, nrOfColumns]);
                }
                Console.WriteLine();
            }
            
        }
        Position SearchNumber(int[,] matrix, int number)
        {
            Position Pos = new Position();
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    if (matrix[nrOfRows, nrOfColumns] == number)
                    {
                        Pos.row = nrOfRows;
                        Pos.colum = nrOfColumns;
                        return Pos;
                    }
                    else
                    {
                        Pos.row = -1;
                        Pos.colum = -1;
                        
                    }
                    
                }
            }
            return Pos;

        }

        Position SearchNumberBackwards(int[,] matrix, int number)
        {

            Position PosBackwards = new Position();
            for (int nrOfRows = matrix.GetLength(0) -1; nrOfRows >= 0; nrOfRows--)
            {
                for (int nrOfColumns = matrix.GetLength(1) -1; nrOfColumns >= 0; nrOfColumns--)
                {
                    if (matrix[nrOfRows, nrOfColumns] == number)
                    {
                        PosBackwards.row = nrOfRows;
                        PosBackwards.colum = nrOfColumns;
                        return PosBackwards;

                    }
                    else
                    {
                        PosBackwards.row = -1;
                        PosBackwards.colum = -1;

                    }

                }
            }
            return PosBackwards;
        }
    }
}
