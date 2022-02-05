using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    public class PayPalBetaling : BetaalWijze
    {
        public override void betaling()
        {
            Console.WriteLine("PayPal betaling verwerken...");
        }
    }
}
