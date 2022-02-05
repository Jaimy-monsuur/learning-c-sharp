using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class Score
    {
        protected int level;
        protected int punten;

        public Score(int level, int punten)
        {
            this.level = level;
            this.punten = punten;
        }

        public virtual int BerekenWaarde()
        {
            return level * punten;
        }

        public override string ToString()
        {
            return $"Score of level {level}: value = {BerekenWaarde()}, points: {punten}";
        }
    }
}
