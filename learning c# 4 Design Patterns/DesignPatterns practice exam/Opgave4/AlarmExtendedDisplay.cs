using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    public class AlarmExtendedDisplay : IAlarmObserver
    {
        private IAlarmSysteem systeem;
        public AlarmExtendedDisplay(IAlarmSysteem systeem)
        {
            this.systeem = systeem;
            this.systeem.AddDisplay(this);
        }
        public void Update(DateTime alarmtime, string melding)
        {
            Console.WriteLine($"[extended alarm-display]: alarm geactiveerd om {alarmtime:dd/MM/yyyy HH:mm:ss} - {melding}");
        }
    }
}
