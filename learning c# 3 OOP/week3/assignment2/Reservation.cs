using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Reservation
    {
        public Customer Customer { get; set; }
        private List<Ticket> tickets;

        public List<Ticket> Tickets
        {
            get { return tickets; }
            set 
            { 
                tickets = value; 
            }
        }
        public double TotalPrice
        {
            get 
            {
                double price = 0;
                foreach (Ticket t in Tickets)
                {
                    if (t.Discount == true)
                    {
                        price += t.Price * 0.95;
                    }
                    else
                    {
                        price += t.Price;
                    }
                }

                if (Customer.Discount == true)
                {
                    price = price * 0.90;
                }
                return price;
            }
        }
        public Reservation(Customer customer)
        {
            this.Customer = customer;

            tickets = new List<Ticket>();// hoezo moet dit??

            Ticket bohemian = new Ticket("Bohemian Rapsody", 10.50)
            {
                StartTime = new DateTime(2021, 02, 13, 21, 30, 0),
                CinemaRoom = 1,
                MinimumAge = 6
            };

            Ticket prodigy = new Ticket("The Prodigy", 10.50)
            {
                StartTime = new DateTime(2021, 02, 13, 22, 00, 0),
                CinemaRoom = 4,
                MinimumAge = 16
            };

            Ticket green = new Ticket("Green Book", 10.50)
            {
                StartTime = new DateTime(2021, 02, 15, 19, 00, 0),
                CinemaRoom = 5,
                MinimumAge = 12
            };

            Tickets.Add(bohemian);
            Tickets.Add(prodigy);
            Tickets.Add(green);
        }

        public string ToString(Ticket t)
        {
            return $"created ticket '{t.MovieName}', start time: {t.StartTime:dd / MM / yyyy HH: mm}, price: {t.Price:0.00}, room: {t.CinemaRoom} ({t.MinimumAge}+)";
        }




    }
}
