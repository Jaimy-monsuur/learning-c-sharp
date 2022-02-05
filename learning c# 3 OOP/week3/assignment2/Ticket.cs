using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Ticket
    {
        private string moviename;

        public string MovieName
        {
            get { return moviename; }
            set 
            { 
                if (value != "") 
                    { moviename = value; }
                else
                {
                    Console.WriteLine("Error occured: Empty movie name!");
                }
            }
        }

        private int cinemaRoom;

        public int CinemaRoom
        {
            get { return cinemaRoom; }
            set 
            { 
                if (value >= 0 || value <= 5) { cinemaRoom = value; }
                else
                {
                    Console.WriteLine($"Error occured: Invalid cinema room ({value})!");
                }
            }
        }

        private DateTime starttime;

        public DateTime StartTime
        {
            get { return starttime; }
            set 
            { 
                if (value.Minute == 30 || value.Minute == 00)
                {
                    starttime = value;
                }
                else
                {
                    Console.WriteLine($"Error occured: Invalid start time! ({value})");
                }
            }
        }

        public bool Discount
        {
            get
            {
                if (starttime.DayOfWeek == DayOfWeek.Monday)
                {
                    return true;
                }
                else if (starttime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private int minimumAge;

        public int MinimumAge
        {
            get { return minimumAge; }
            set 
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16)
                {
                    minimumAge = value;
                }
                else
                {
                    Console.WriteLine($"Error occured: Invalid minimum age ({value})!");
                }
            }
        }

        public double Price { get; set; }

        public Ticket(string name, double price)
        {
            this.MovieName = name;
            this.Price = price;
        }
    }
}
