using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class StoreItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalPrice
        {
            get { return Count * Price; }
        }


        public StoreItem(string title, double price, int count)
        {
            this.Title = title;
            this.Price = price;
            this.Count = count;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{Title}, {Price}");
        }
    }
}
