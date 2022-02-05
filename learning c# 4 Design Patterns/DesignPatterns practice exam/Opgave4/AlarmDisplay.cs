using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    public class AlarmDisplay : IAlarmObserver
    {
        private IAlarmSysteem systeem;
        public AlarmDisplay(IAlarmSysteem systeem)
        {
            this.systeem = systeem;
            this.systeem.AddDisplay(this);
        }
        public void Update(DateTime alarmtime, string melding)
        {
            Console.WriteLine($"[alarm-display]: alarm geactiveerd om {alarmtime:dd/MM/yyyy HH:mm:ss}");
        }
    }
}
