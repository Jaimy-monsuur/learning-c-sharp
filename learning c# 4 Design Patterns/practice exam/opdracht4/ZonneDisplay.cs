using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    public class ZonneDisplay : IObserver
    {
        private IObservable _systeem;

        public ZonneDisplay(IObservable systeem)
        {
            _systeem = systeem;
        }

        public void Update(int meting)
        {
            Console.WriteLine($"nieuwe meting: {meting} Watt");
        }

    }
}
