using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    public class JukeBox
    {
        private IVinylSingle _currentSingle;
        public List<IVinylSingle> _Singles;

        public JukeBox(List<IVinylSingle> singles)
        {
            _Singles = singles;
        }

        public void Afspelen()
        {
            _currentSingle.Play();
        }

        public void SelectSingle(int index)
        {
            _currentSingle = _Singles[index];
        }

        public void Stoppen()
        {
            _currentSingle.Stop();
        }
    }
}
