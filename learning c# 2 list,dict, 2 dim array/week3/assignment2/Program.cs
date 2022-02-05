using System;
using System.Collections.Generic;

namespace assignment2
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
            HangmanGame hangman = new HangmanGame();


            List<string> words = ListOfWords();
            string selectWord = SelectWord(words);
            hangman.Init(selectWord);

            bool won = PlayHangman(hangman);
            if (won == true)
            {
                Console.WriteLine("You guessed the word!");
            }
            else
            {
                Console.WriteLine($"Too bad, you did not guess the word ({hangman.secretWord})");
            }
            
            

            Console.ReadKey();
        }
        List<string> ListOfWords()
        {
            List<string> words = new List<string>();
            words.Add("airplane");
            words.Add("kitchen");
            words.Add("building");
            words.Add("incredible");
            words.Add("funny");
            words.Add("trainstation");
            words.Add("neighbour");
            words.Add("different");
            words.Add("department");
            words.Add("planet");
            words.Add("presentation");
            words.Add("embarrassment");
            words.Add("integration");
            words.Add("scenario");
            words.Add("discount");
            words.Add("management");
            words.Add("understanding");
            words.Add("registration");
            words.Add("security");
            words.Add("language");

            return words;
        }

        string SelectWord(List<string> words)
        {
            Random rnd = new Random();;
            string selectWord = words[rnd.Next(0, 20)];
            return selectWord;
        }

        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            List<char> blacklistLetters = new List<char>();
            int attempts = 8;

            DisplayWord(hangman.guessedWord);
            Console.WriteLine();

            while (attempts != 0 )
            {

                char letter = ReadLetter(blacklistLetters);
                enteredLetters.Add(letter);
                blacklistLetters.Add(letter);
                bool ifTrue = hangman.ContainsLetter(letter);

                if (ifTrue == true)
                {
                    hangman.ProcessLetter(letter);
                }
                else
                {
                    attempts--;
                }

                DisplayLetters(enteredLetters);
                Console.WriteLine("Attempts left: " + attempts);
                DisplayWord(hangman.guessedWord);
                Console.WriteLine();

                bool isGuessed = hangman.IsGuessed();
                if (isGuessed == true)
                {
                    return true;
                }

            }
            return false; 
        }

        void DisplayWord(string word)
        {
            string guessedWord = "";
            foreach (char c in word)
            {
                guessedWord = guessedWord + c + " ";
            }
            Console.WriteLine(guessedWord);
            
        }

        void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters: ");
            foreach (char c in letters)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        char ReadLetter(List<char> blacklistLetters)
        {
            Console.Write("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            while (blacklistLetters.Contains(letter))
            {
                Console.Write("Enter a letter: ");
                letter = char.Parse(Console.ReadLine());
            }
            return letter;
        }
    }
}
