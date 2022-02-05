using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNcalculate_Click(object sender, EventArgs e)
        {
            //declaring stuff
            double degrees = double.Parse(TXBinput.Text);
            double kelvin;
            double fahrenheit;
            double celcius;
            double concertedDegrees = 0;

            if (RBTNcelsius2kelvin.Checked)
            {
                concertedDegrees = Celsius2Kelvin(degrees, out kelvin);
            }
            else if (RBTNCelsius2Fahrenheit.Checked)
            {
                concertedDegrees = Celsius2Fahrenheit(degrees,out fahrenheit);
            }
            else if (RBTNFahrenheit2Celsius.Checked)
            {
                concertedDegrees = Fahrenheit2Celsius(degrees, out celcius);
            }
            LBLoutput.Text = concertedDegrees.ToString("0.00");
        }
        double Celsius2Kelvin(double degrees, out double kelvin)
        {
            kelvin = degrees + 273;
            return kelvin;
        }

        double Celsius2Fahrenheit(double degrees, out double fahrenheit)
        {
            fahrenheit = (degrees * 9) / 5 + 32;
            return fahrenheit;
        }

        double Fahrenheit2Celsius(double degrees, out double celcius)
        {
            celcius = (degrees - 32) * 5 / 9;
            return celcius;
        }
    }
}
