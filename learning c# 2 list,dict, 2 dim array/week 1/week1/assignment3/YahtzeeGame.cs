using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class YahtzeeGame
    {
        const int LenghtDice = 5;
        Dice[] dice = new Dice[LenghtDice];

        public void Init()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Dice dice1 = new Dice();
                dice[i] = dice1;
            }
        }
        public void Throw()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Throw();
            }
            
        }
        public void DisplayValues()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].DisplayValue();
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            bool Yahtzee = true;

            int firstThrow = dice[0].value; 
            for (int i = 1; i < dice.Length; i++) 
            { 
                if (dice[i].value != firstThrow) 
                { 
                    return false; 
                }            
            }

            return Yahtzee;
        }
    }
}
