using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class Voedsel : Voorwerp
    {
        public int Calorieen { get; set; }
        public Voedsel(int gewicht, int calorieen)
            : base(gewicht)
        {
            this.Calorieen = calorieen;      
        }
    }
}
