using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Magazine : StoreItem
    {
        public string Releaseday { get; private set; }
        public Magazine(string title, string releaseday, double price, int count)
                        : base(title, price, count)
        {
            this.Releaseday = releaseday;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day:{Releaseday}, {Price:0.00} ({Count}x)");
        }
    }
}
