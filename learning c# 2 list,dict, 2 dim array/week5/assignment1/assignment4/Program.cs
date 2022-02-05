using System;
using System.IO;
using System.Collections.Generic;
using MyTools;

namespace assignment4
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
            List<string> words = new List<string>();
            LingoGame lingoGame = new LingoGame();

            words = ReadWords(filename, 5);
            string lingoWord = SelectWord(words);
            lingoGame.Init(lingoWord);
            bool play = PlayLingo(lingoGame);
            if (play == true)
            {
                Console.WriteLine("you have guessed the word");
            }
            else
            {
                Console.WriteLine($"too bad, you did not guess the word ({lingoWord})");
            }
        }

        List<string> ReadWords(string filename,int wordLength)
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                string word = reader.ReadLine();
                if (word.Length == wordLength)
                {
                    words.Add(word);
                }
                
            }
            reader.Close();
            return words;
        }

        string SelectWord(List<string> words)
        {
            Random rnd = new Random(); 
            string selectWord = words[rnd.Next(0, words.Count)];
            
            return selectWord;
        }

       bool PlayLingo(LingoGame lingoGame)
        {

            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;
            int count = 1;

            while (attemptsLeft > 0 && !lingoGame.WordGuessed())
            {
                string playerWord = ReadPlayerWord(wordLength, count);
                LingoGame.LetterState[] letterResults = lingoGame.ProcessWord(playerWord);
                DisplayPlayerWord(playerWord, letterResults);

                attemptsLeft = attemptsLeft - 1;
                count++;
            }
            return lingoGame.WordGuessed();
        }

       string ReadPlayerWord(int length, int count)
        {
            
            string word = null;
            do
            {
                
                word = ReadTools.ReadString($"Enter a (5 letter) word, atempt {count}: ");
                
            } while (word.Length != length);
            string word2 = word.ToUpperInvariant();
            return word2;
        }

        void DisplayPlayerWord(string playerWord, LingoGame.LetterState[] letterResults)
        {
            for (int i = 0; i < playerWord.Length; i++)
            {
                if (letterResults[i] == LingoGame.LetterState.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (letterResults[i] == LingoGame.LetterState.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }

                Console.Write(playerWord[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

    }
}
