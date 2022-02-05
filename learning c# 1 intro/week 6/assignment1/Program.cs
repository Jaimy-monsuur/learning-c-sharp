using System;
using System.Globalization;
using System.Threading;


namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            //aks price
            Console.Write("Enter a price: ");
            float Input = float.Parse(Console.ReadLine());
            float VATPrice = PRICEVAT(Input);

            float PriceTotal = VATPrice + Input;
            Console.Write($"Price: {Input:.00}, VAT: {VATPrice:.00}, total: {PriceTotal:.00}");

        }
        static float PRICEVAT(float Input)
        {
            float VAT = 0.21f;
            float VATPrice = VAT * Input;
            return VATPrice;
        }
    }
}

