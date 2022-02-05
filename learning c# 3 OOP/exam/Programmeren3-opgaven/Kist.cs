using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    class Kist : Container
    {
        public Kist(int maxgewicht, int gewicht)// gewicht is toegevoegd voor opgaven 6
            : base(maxgewicht, gewicht) { }
    }
}
