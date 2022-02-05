using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    public interface IAlarmSysteem
    {
        public void ActiveerAlarm(string melding);
        public void AddDisplay(IAlarmObserver display);
        public void RemoveDisplay(IAlarmObserver display);
    }
}
