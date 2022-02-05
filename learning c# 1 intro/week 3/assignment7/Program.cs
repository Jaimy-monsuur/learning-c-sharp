using System;
using System.Globalization;
using System.Threading;

namespace opdracht7
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            //ask weight, lenght and gender
            Console.Write("Enter your weight (Kg): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Enter your lenght (Cm): ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter your Gender: ");
            string gender = Console.ReadLine();

            //calculate bmi
            float squere_of_height = (length / 100) * (length / 100);
            float FBMI = weight / squere_of_height;
            string BMI = FBMI.ToString("0.0");

            //gewicht man
            float Fminweightmale = 20 * squere_of_height;
            float Fmaxweightmale = 25 * squere_of_height;
            string minweightmale = Fminweightmale.ToString("0.0");
            string maxweightmale = Fmaxweightmale.ToString("0.0");

            //gewicht vrouw
            float Fminweightfemale = 19 * squere_of_height;
            float Fmaxweightfemale = 24 * squere_of_height;
            string minweightfemale = Fminweightfemale.ToString("0.0");
            string maxweightfemale = Fmaxweightfemale.ToString("0.0");

            //witregel
            Console.WriteLine();

            //display BMI
            Console.WriteLine("bmi-value: " + BMI);

            switch (gender)
            {
                case "male":
                    Console.WriteLine("normal bmi-value (min .. max ): 20..25");
                    Console.WriteLine("healthy weight between {0}..{1}" ,minweightmale , maxweightmale);
                    break;
                case "female":
                    Console.WriteLine("normal bmi-value (min .. max): 19..24");
                    Console.WriteLine("healthy weight between {0}..{1}" ,minweightfemale , maxweightfemale);
                    break;

            }

            Console.ReadKey();
        }
    }
}
