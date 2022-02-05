using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class HoutenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            Console.WriteLine("houten dak plaatsen");
        }

        public override void MurenPlaatsen()
        {
            Console.WriteLine("houten muren plaatsen");
        }
    }
}
