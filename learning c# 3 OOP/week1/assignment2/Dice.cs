using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class Dice
    {
        public int value;
        Random rnd;

        public Dice(Random random)
        {
            this.rnd = random;
        }
        public void Throw()
        {
            value = rnd.Next(1, 7);
        }

        public void DisplayValue()
        {
            Console.Write(value);
        }
    }
}
