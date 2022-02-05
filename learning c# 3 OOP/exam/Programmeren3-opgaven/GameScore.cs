using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class GameScore
    {
        public List<Score> Scores { get; private set; }
        public DateTime time { get; set; }

        private string naam;

        public string Naam
        {
            get { return naam; }
        }
        public int Waarde
        {
            get
            {
                int total = 0;
                foreach (Score score in Scores)
                {
                    total += score.BerekenWaarde();
                }
                return total;
            }
        }
        public GameScore(string naam, DateTime time)
        {
            this.naam = naam;
            this.time = time;
            Scores = new List<Score>();       
        }
    }
}
