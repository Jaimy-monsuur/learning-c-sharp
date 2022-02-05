using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    public interface IAlarmObserver
    {
        public void Update(DateTime alarmtime ,string melding);
    }
}
