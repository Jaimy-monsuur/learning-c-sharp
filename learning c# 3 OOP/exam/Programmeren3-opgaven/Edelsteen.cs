using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class Edelsteen : Voorwerp
    {
        public int Waarde { get; set; }
        public Edelsteen(int gewicht, int waarde)
            : base(gewicht)
        {
            this.Waarde = waarde;
        }
    }
}
