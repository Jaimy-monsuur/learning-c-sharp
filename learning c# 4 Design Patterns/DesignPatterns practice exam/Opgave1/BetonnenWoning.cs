using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class BetonnenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            Console.WriteLine("betonnen dak plaatsen");
        }

        public override void MurenPlaatsen()
        {
            Console.WriteLine("betonnen muren plaatsen");
        }
    }
}
