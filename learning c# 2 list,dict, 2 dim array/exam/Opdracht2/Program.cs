using System;



namespace Opdracht2
{
    class Program
    {
        const int nrOfRows = 5;
        const int nrOfColumns = 5;
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
            int[,] bingoKaart = new int[nrOfRows, nrOfColumns];
            VulBingoKaart(bingoKaart);
            ToonBingoKaart(bingoKaart);

        }
        void VulBingoKolom(int[,] bingoKaart, int kolom, int minGetal, int maxGetal)
        {
            int[] check = new int[bingoKaart.GetLength(1)];
            Random rnd = new Random();
            for (int Rows = 0; Rows < bingoKaart.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < bingoKaart.GetLength(1); Columns++)
                {
                    if (Columns == kolom)
                    {
                        bingoKaart[Rows, Columns] = rnd.Next(minGetal, maxGetal);
                        check[Columns] = bingoKaart[Rows, Columns];
                    }
                }
            }
            //mhhh is niet zo mooi
            for (int Rows = 0; Rows < bingoKaart.GetLength(0); Rows++)
            {
                foreach (int number in check)
                {
                    if (number == bingoKaart[Rows, kolom])
                    {
                        while (number == bingoKaart[Rows, kolom])
                        {
                            bingoKaart[Rows, kolom] = rnd.Next(minGetal, maxGetal);
                        }
                    }

                }
            }
        }

        void VulBingoKaart(int[,] bingoKaart)
        {
            int min = 1;
            int max = 15;
            for (int Columns = 0; Columns < bingoKaart.GetLength(1); Columns++)
            {
                VulBingoKolom(bingoKaart, Columns, min, max);
                min += 15;
                max += 015;
            }
            int halfrow = nrOfRows / 2;
            int halfcol = nrOfColumns / 2;
            bingoKaart[halfrow, halfcol] = 0;
        }

        void ToonBingoKaart(int[,] matrix)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    B I N G O");
            Console.ResetColor();
            for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
                {
                    if (matrix[Rows, Columns] <= 0)
                    {
                        Console.Write(" --");
                    }
                    else
                    {
                        Console.Write("{0, 3}", matrix[Rows, Columns]);// use "{0:00} " for 04,06 ect.
                    }
                }
                    
                Console.WriteLine();
            }
        }
    }
}
