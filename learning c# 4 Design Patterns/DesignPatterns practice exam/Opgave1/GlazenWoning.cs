using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class GlazenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            Console.WriteLine("glazen dak plaatsen");
        }

        public override void MurenPlaatsen()
        {
            Console.WriteLine("glazen muren plaatsen");

        }
    }
}
