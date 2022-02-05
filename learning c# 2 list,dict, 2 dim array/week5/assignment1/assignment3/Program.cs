using System;
using System.IO;
using System.Collections.Generic;


namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[3-4] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            words = ReadWords(filename);
            TranslateWords(words);

        }

        Dictionary<string, string> ReadWords(string filename)
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] LineValue = line.Split(';');
                Dict.Add(LineValue[0], LineValue[1]);
            }
            reader.Close();
            return Dict;
        }

        void TranslateWords(Dictionary<string, string> words)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (words.ContainsKey(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(input + " => " + words[input]);
                    Console.ResetColor();
                }
                else if (input == "listall")
                {
                    ListAllWords(words);
                }
                else
                {
                    Console.WriteLine($"word '{input}' not found");
                }

                Console.Write("Enter a word: ");
                input = Console.ReadLine();
            }

            void ListAllWords(Dictionary<string, string> words)
            {
                foreach (KeyValuePair<string, string> word in words)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(word.Key + " => " + word.Value);
                    Console.ResetColor();
                }
            }
        }
    }
}
