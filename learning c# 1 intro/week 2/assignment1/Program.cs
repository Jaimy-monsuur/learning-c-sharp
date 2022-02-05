using System;
using System.Globalization;
using System.Threading;



namespace opdrachten_week_2
{
    class Program
    {
      const double VAT = 0.21;

        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // variabele price
            double Price;

            // Enter a price
            Console.Write("Enter a price: ");
            string Input = Console.ReadLine();

            // invoer naar double
            Price = double.Parse(Input);

            //VAT is 
            double Pricevat = Price * VAT;

            //Price total
            double PriceTotal = Price + Pricevat;

            //Show price
            Console.Write($"Price: {Price:0.00}, ");
            Console.Write($"VAT: {Pricevat:0.00}, ");
            Console.Write($"Total: {PriceTotal:0.00}, ");

            Console.ReadKey();
        }
    }
}
