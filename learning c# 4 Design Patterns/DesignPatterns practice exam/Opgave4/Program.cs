using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        private void Start()
        {
            // maak alarmsysteem aan
            IAlarmSysteem alarmSysteem = new AlarmSysteem();

            // maak een controller aan
            IAlarmController controller = new AlarmController(alarmSysteem);

            // maak displays aan
            IAlarmObserver alarmDisplay = new AlarmDisplay(alarmSysteem);
            IAlarmObserver alarmExtendedDisplay = new AlarmExtendedDisplay(alarmSysteem);

            // activeer het alarmsysteem een paar keer (om te testen)
            controller.ActiveerAlarm("achterdeur staat open");
            Console.WriteLine();
            controller.ActiveerAlarm("tocht bij raam 1e verdieping");
            Console.WriteLine();
        }
    }
}
