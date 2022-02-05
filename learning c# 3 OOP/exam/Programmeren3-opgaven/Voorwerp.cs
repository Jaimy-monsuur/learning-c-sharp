using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public abstract class Voorwerp
    {
        public int Gewicht { get; private set; }
        public Voorwerp(int gewicht)
        {
            this.Gewicht = gewicht;
        }
    }
}
