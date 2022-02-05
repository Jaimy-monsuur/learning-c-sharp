using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public enum Wapens
    {
        Zwaard, Bijl, Kruisboog, Dolk
    }
    public class Wapen : Voorwerp
    {
        public Wapens wapen;
        public Wapen(int gewicht, Wapens wapen)
            : base(gewicht)
        {
            this.wapen = wapen; 
        }
    }
}
