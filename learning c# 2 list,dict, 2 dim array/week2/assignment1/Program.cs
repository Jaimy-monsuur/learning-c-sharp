using System;

namespace assignment1
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
            

            InitMatrixLinear(matrix);
            DisplayMatrix(matrix);
            Console.WriteLine();
            DisplayMatrixWithCross(matrix);

            Console.ReadKey();
        }
        void InitMatrix2D(int[,] matrix)
        {
            int number = 1;
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    matrix[nrOfRows, nrOfColumns] = number;
                    number++;
                }
            }
        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    Console.Write("{0, 3}", matrix[nrOfRows, nrOfColumns] );
                }
                Console.WriteLine();
            }
        }
        void InitMatrixLinear(int[,] matrix)
        {

            for (int getal = 1; getal <= matrix.Length; getal++)
            {
                int nrOfRows = (getal - 1) / matrix.GetLength(1);// delen door aantal kolommen
                int nrOfColumns = (getal - 1) % matrix.GetLength(1);// modulo aantal kolommen
                matrix[nrOfRows, nrOfColumns] = getal;
            }

        }

        void DisplayMatrixWithCross(int[,] matrix)
        {
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    if (nrOfRows == nrOfColumns)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if ((nrOfRows + nrOfColumns) == matrix.GetLength(1) -1)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    

                    Console.Write("{0, 3}", matrix[nrOfRows, nrOfColumns]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

    }
}
