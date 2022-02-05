using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class YahtzeeGame
    {
        const int LenghtDice = 5;
        Dice[] dice = new Dice[LenghtDice];



        public YahtzeeGame()
        {
            Random rnd = new Random();
            for (int i = 0; i < dice.Length; i++)
            {  
                Dice dice1 = new Dice(rnd);
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
            bool Yahtzee = false;
            int CheckValue = dice[0].value;
            int count = 0;

            foreach (Dice d in dice)
            {
                int Number = d.value;
                if (Number == CheckValue)
                {
                    count++;
                }

                if (count == LenghtDice)
                {
                    Yahtzee = true;
                }


            }
            return Yahtzee;
        }
    }
}
