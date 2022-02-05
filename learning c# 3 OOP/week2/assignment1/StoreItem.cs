using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class StoreItem
    {
        public string title;
        public double price;

        public StoreItem(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{title}, {price}");
        }
    }
}
