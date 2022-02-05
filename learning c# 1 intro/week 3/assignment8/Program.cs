using System;
using System.Text;

namespace opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of working hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of yeeats: ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of failures: ");
            int fails = int.Parse(Console.ReadLine());

            bool replacment = false;
            // is replacment true??
            if (hours > 10000)
            {
                replacment = true;
            }
            else if (years > 7)
            {
                replacment = true;
            }
            else if (fails > 25)
            {
                replacment = true;
            }

            // if replacment is true then
            if (replacment == true)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }
        }
    }
}
