using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    public class AlarmController : IAlarmController
    {
        private IAlarmSysteem alarm;
        public AlarmController(IAlarmSysteem alarm)
        {
            this.alarm = alarm;
        }
        public void ActiveerAlarm(string melding)
        {
            alarm.ActiveerAlarm(melding);
        }
    }
}
