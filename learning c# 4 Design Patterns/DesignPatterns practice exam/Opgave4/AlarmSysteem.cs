using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    public class AlarmSysteem : IAlarmSysteem //observable
    {
        public DateTime AlarmDatumTijd { get; set; }
        public string AlarmMelding { get; set; }
        List<IAlarmObserver> displays;
        public AlarmSysteem()
        {
            displays = new List<IAlarmObserver>();
        }

        public void ActiveerAlarm(string melding)
        {
            this.AlarmMelding = melding;
            this.AlarmDatumTijd = DateTime.Now;
            UpdateDisplay();
        }
        public void UpdateDisplay()
        {
            foreach (IAlarmObserver display in displays)
            {
                display.Update(AlarmDatumTijd, AlarmMelding);
            }
        }
        public void AddDisplay(IAlarmObserver display)
        {
            displays.Add(display);
        }

        public void RemoveDisplay(IAlarmObserver display)
        {
            displays.Remove(display);
        }
    }
}
