using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;
        
        public void Init(string SecretWord)
        {
            secretWord = SecretWord;
            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord = guessedWord + ".";
            }
        }

        public bool ContainsLetter(char letter)
        {
            bool containsletter = false;
            if (secretWord.Contains(letter))
            {
                containsletter = true;
            }
            return containsletter;
        }

        public void ProcessLetter(char letter)
        {
            StringBuilder s = new StringBuilder(guessedWord);
            for (int i = 0; i < secretWord.Length; i++)
            {
                char c = secretWord[i];
                if (c == letter)
                {
                    s.Remove(i, 1);
                    s.Insert(i, letter);
                    guessedWord = s.ToString();
                }
            }
        }

        public bool IsGuessed()
        {
            bool guessed = false;
            if (guessedWord == secretWord)
            {
                guessed = true;
            }
            return guessed;
        }

    }
}
