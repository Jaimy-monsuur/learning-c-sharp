using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class TrainStation
    {
        public string name;
        public string arrival_track;
        public string arrival_time;
        public string departure_time;

        public TrainStation(string name, string arrivaltrack, string arrivaltime, string departuretime)
        {
            this.name = name;
            this.arrival_track = arrivaltrack;
            this.arrival_time = arrivaltime;
            this.departure_time = departuretime;
        }
    }
}
