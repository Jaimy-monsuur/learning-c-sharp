using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Reservation
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime ReservationDateTime { get; set; }
        public Book B { get; set; }
        public Customer C { get; set; }
        public Reservation(int id, Customer customer, Book book)
        {
            this.Id = id;
            this.B = book;
            this.C = customer;
        }
        public override string ToString()
        {
            return C.ToString() + " -> " + B.ToString();
        }
    }
}
