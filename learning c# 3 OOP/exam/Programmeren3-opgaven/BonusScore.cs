using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class BonusScore : Score
    {
        protected int bonus;
        public BonusScore(int level, int punten, int bonus)
            : base(level, punten)
        {
            this.bonus = bonus;
        }
        public override int BerekenWaarde()
        {
            return base.BerekenWaarde() + bonus * 10;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, bonus: {bonus}";
        }
    }
}
