using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3
{
    class KopieerMachine
    {
        private static KopieerMachine _KopieerMachine;
        private int _aantalKopies;

        private KopieerMachine() { }

        public static KopieerMachine getInstance()
        {
            if(_KopieerMachine is null)
            {
                _KopieerMachine = new KopieerMachine();
            }
            return _KopieerMachine;
        }

        public void Kopieer(int aantal)
        {
            Console.WriteLine($"aan het kopieren, {aantal}x");
            _aantalKopies += aantal;
            Console.WriteLine($"totaal kopies: {_aantalKopies}x");
        }
    }
}
