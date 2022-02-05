using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    public abstract class BetaalWijze
    {
        public void Uitvoeren()
        {
            invoerGegevens();
            betaling();
            bevestigingsmail();
        }

        public void invoerGegevens()
        {
            Console.WriteLine("invoeren van gegevens...");
        }

        public abstract void betaling();

        public void bevestigingsmail()
        {
            Console.WriteLine("bevestigingsmail versturen...");
        }
    }
}
