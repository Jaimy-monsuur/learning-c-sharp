using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Bookstore
    {
        private List<StoreItem> Stock = new List<StoreItem>();
        public double StockPrice { get; set; }
        public void Add(StoreItem book)
        {
            Stock.Add(book);
        }

        public void PrintCompleteStock()
        {
            foreach (StoreItem item in Stock)
            {
                item.Print();
                this.StockPrice += item.TotalPrice;
            }
            Console.WriteLine($"\n Total sales price: {StockPrice:0.00}");
        }

    }
}
