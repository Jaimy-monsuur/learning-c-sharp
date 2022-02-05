using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void BTNcalc_Click(object sender, EventArgs e)
        {
            string input = TXBage.Text;
            double age = double.Parse(input);

            double price = 12;

            if (age < 5)
            {
                price = 0.00;
            }
            if (age >= 5 && age <= 12)
            {
                price = price / 2;
            }
            if (age > 54)
            {
                price = 0.00;
            }
            LBLfrice.Text = price.ToString("0.00");
        }
    }
}
