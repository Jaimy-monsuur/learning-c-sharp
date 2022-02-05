using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    public interface IObservable
    {
        public void AddDisplay(IObserver display);
        public void RemoveDisplay(IObserver display);
        public void NieuweMeting();
    }
}
