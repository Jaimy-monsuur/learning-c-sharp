using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    public class PaneelController : IPaneelController
    {
        private IObservable _Zonnepaneel;
        public PaneelController(IObservable zonnepaneel)
        {
            _Zonnepaneel = zonnepaneel;
        }
        public void NieuweMeting()
        {
            _Zonnepaneel.NieuweMeting();
        }
    }
}
