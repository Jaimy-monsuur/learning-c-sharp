using System;
using System.Collections.Generic;
using System.Text;

namespace ConwayGameOfLife
{
    public interface ILifeBehaviour
    {
        bool CellShouldLive(bool livingCell, int neighbourCount);
    }
}
