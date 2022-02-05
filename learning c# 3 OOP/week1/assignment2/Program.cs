﻿using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            PlayYahtzee(yahtzeeGame); // play the game
        }
        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;
            do
            {
                game.Throw(); // throw all dices
                game.DisplayValues(); // display the thrown
                nrOfAttempts++;
            } while (!game.Yahtzee());
            Console.WriteLine("Number of attempts needed (for Yahtzee): {0}", nrOfAttempts);

        }
    }
}
