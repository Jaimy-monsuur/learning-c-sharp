using System;

namespace opdracht2
{
    class Program
    {
        const int nrOfRows = 5;
        const int nrOfColumns = 10;
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
            int[,] matrix = new int[nrOfRows, nrOfColumns];
            VulMatrix(matrix);
            ToonMatrix(matrix);
            Console.Write("\ngeef een getal: ");
            int getal = int.Parse(Console.ReadLine());
            VerschuifMatrix(matrix, getal);
            Console.WriteLine();
            ToonMatrix(matrix);
        }

        void VulMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
                {
                    matrix[Rows, Columns] = rnd.Next(1, 100);
                    
                }
            }
        }

        void ToonMatrix(int[,] matrix)
        {
            for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
                {
                    Console.Write("{0:00} ", matrix[Rows, Columns]);
                }
                Console.WriteLine();
            }
        }

        void VerschuifMatrix(int[,] matrix, int zoekgetal)
        {
            
            for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
                {
                    if (matrix[Rows, Columns] == zoekgetal)
                    {
                        Console.WriteLine("shift row {0} starting from column {1}...", Rows ,Columns);
                        VerschuifRij(matrix, Rows, Columns);
                        break;
                    }
                }
            }
        }

        void VerschuifRij(int[,] matrix, int Rows, int Columns)
        {

            int[] tijdelijk = new int [matrix.GetLength(1)];
            for (int Col = 0; Col < matrix.GetLength(1); Col++)
            {
                tijdelijk[Col] = matrix[Rows, Columns];
                Columns += 1;
                if (Columns == matrix.GetLength(1))
                {
                    Columns = 0;
                }
 
            }
            for (int Col = 0; Col < matrix.GetLength(1); Col++)
            {
                matrix[Rows, Col] = tijdelijk[Col];
            }

        }
    }
}
