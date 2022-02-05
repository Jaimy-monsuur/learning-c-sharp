using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Bookstore
    {
        public List<StoreItem> Stock = new List<StoreItem>();
        public double StockPrice;
        public void Add(StoreItem book)
        {
            Stock.Add(book);
        }

        public void PrintCompleteStock()
        {
            foreach (StoreItem item in Stock)
            {
                item.Print();
                this.StockPrice += item.price;
            }
            Console.WriteLine($"\n Total sales price: {StockPrice:0.00}");
        }

    }
}
