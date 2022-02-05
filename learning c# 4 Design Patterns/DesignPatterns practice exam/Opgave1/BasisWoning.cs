using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public abstract class BasisWoning
    {
        public void WoningBouwen()
        {
            FunderingPlaatsen();
            MurenPlaatsen();
            DakPlaatsen();
            RamenPlaatsen();
        }
        public void FunderingPlaatsen()
        {
            Console.WriteLine("fundering met beton en ijzer plaatsen");
        }
        public abstract void MurenPlaatsen();
        public abstract void DakPlaatsen();
        public void RamenPlaatsen()
        {
            Console.WriteLine("glazen ramen plaatsen");
        }
    }
}
