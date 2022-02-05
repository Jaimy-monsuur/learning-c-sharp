using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Magazine : StoreItem
    {
        string releaseday;
        public Magazine(string title, string releaseday, double price)
                        : base(title, price)
        {
            this.releaseday = releaseday;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] {title} - release day:{releaseday}, {price:0.00}");
        }
    }
}
