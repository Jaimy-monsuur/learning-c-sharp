using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNplus_Click(object sender, EventArgs e)
        {
            double result;
            double number1 = double.Parse(TXBnumber1.Text);
            double number2 = double.Parse(TXBnumber2.Text);

            result = number1 + number2;

            LBLresult.Text = result.ToString();

        }

        private void BTNmin_Click(object sender, EventArgs e)
        {
            double result;
            double number1 = double.Parse(TXBnumber1.Text);
            double number2 = double.Parse(TXBnumber2.Text);

            result = number1 - number2;

            LBLresult.Text = result.ToString();
        }

        private void BTNkeer_Click(object sender, EventArgs e)
        {
            double result;
            double number1 = double.Parse(TXBnumber1.Text);
            double number2 = double.Parse(TXBnumber2.Text);

            result = number1 * number2;

            LBLresult.Text = result.ToString();
        }

        private void BTNdelen_Click(object sender, EventArgs e)
        {
            double result;
            double number1 = double.Parse(TXBnumber1.Text);
            double number2 = double.Parse(TXBnumber2.Text);

            result = number1 / number2;

            LBLresult.Text = result.ToString();
        }
    }
}
