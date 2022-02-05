using System;
using System.IO;


namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[2-3] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();

            myProgram.Start(filename);
        }
        void Start(string filename)
        {

            Console.Write("Enter a word (to search): ");
            string word = Console.ReadLine();
            Console.WriteLine();
            int count = SearchWordInFile(filename, word);

            Console.WriteLine($"\nNumber of lines containing the word: {count}");
            Console.ReadLine();

        }

        bool WordInLine(string line, string word)
        {
            bool wordinline = false;

            if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                wordinline = true;
            }

            return wordinline;
        }

        void DisplayWordInLine(string line, string word)
        {

            int start = line.IndexOf(word, StringComparison.OrdinalIgnoreCase);

            string line1 = line.Substring(0, start);

            int end = start + word.Length;
            string line2 = line.Substring(end);
            string WordinLine = line.Substring(start, word.Length);

            word = $"[{WordinLine}]";

            Console.Write(line1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(word );
            Console.ResetColor();
            Console.Write(line2);
            Console.WriteLine();
            

        }

        int SearchWordInFile(string filename, string word)
        {
            int count = 0;
            try
            {
                StreamReader reader = new StreamReader(filename);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    bool wordinline = WordInLine(line, word);

                    if (wordinline == true)
                    {
                        DisplayWordInLine(line, word);
                        count++;
                    }
                    wordinline = false;

                    
                }
            }
            catch
            {
                filename = ($"{filename}.txt");
                StreamReader reader = new StreamReader(filename);
                while (reader.ReadLine() != null)
                {
                    string line = reader.ReadLine();
                    bool wordinline = WordInLine(line, word);

                    if (wordinline == true)
                    {
                        DisplayWordInLine(line, word);
                        count++;
                    }
                    wordinline = false;                   

                }
                
            }
            finally
            {
                StreamReader reader = new StreamReader(filename);
                reader.Close();
            }
            
            return count;
        }

    }
}
