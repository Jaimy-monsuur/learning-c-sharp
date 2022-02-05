using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    public class ZonnepaneelSysteem : IObservable
    {
        private Random _rnd;
        private List<IObserver> _Displays;
        private int _Wattage;
        public ZonnepaneelSysteem()
        {
            _Displays = new List<IObserver>();
            _rnd = new Random();
        }

        public void NieuweMeting()
        {
            _Wattage = _rnd.Next(300, 400);
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            foreach(IObserver display in _Displays)
            {
                display.Update(_Wattage);
            }
        }

        public void AddDisplay(IObserver display)
        {
            _Displays.Add(display);
        }

        public void RemoveDisplay(IObserver display)
        {
            _Displays.Remove(display);
        }
    }
}
