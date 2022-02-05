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
            bool Yahtzee = false;
            int CheckValue = dice[0].value;
            int count = 0;

            foreach (Dice d in dice)
            {
                // kan d niet gerbuiken want is niet zelfde datatype
                // int.parse werkt niet maar convert.toint32 wel hoe komt dit vraag aan docent
                //convert.toint gaf tijdens het runnen ook errors. ik kreeg een tip met dat .value wel zou werken.
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
