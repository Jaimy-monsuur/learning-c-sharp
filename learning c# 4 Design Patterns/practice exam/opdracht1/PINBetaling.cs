using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    public class PINBetaling : BetaalWijze
    {
        public override void betaling()
        {
            Console.WriteLine("PIN betaling verwerken...");
        }
    }
}
