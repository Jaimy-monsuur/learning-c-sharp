using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    abstract class Container : Voorwerp// voor opgaven 6
    {
        private int maxGewicht;
        public List<Voorwerp> inhoud;
        public new int Gewicht { get; set; }// toegevoegd voor opdracht 6
        public Container(int maxgewicht, int gewicht)// gewicht is toegevoegd voor opgaven 6
            : base(gewicht)
        {
            this.maxGewicht = maxgewicht;
            inhoud = new List<Voorwerp>();
        }
        public void Voegtoe(Voorwerp voorwerp)
        {
            if (this.Gewicht + voorwerp.Gewicht <= this.maxGewicht)
            {
                inhoud.Add(voorwerp);
                this.Gewicht += voorwerp.Gewicht;
            }
            else
            {
                throw new ArgumentException("Voorwerp is te zwaar!");
            }
        }

        public int BerekenGewicht()
        {
            int totaalGewicht = 0;
            foreach (Voorwerp voorwerp in inhoud)
            {
                totaalGewicht += voorwerp.Gewicht;
            }
            return totaalGewicht;
        }
    }
}
