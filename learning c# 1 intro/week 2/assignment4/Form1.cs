using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Const
            const double VAT = 0.21;

            double Price = double.Parse(TXBinput.Text);

            double PriceVAT = Price * VAT;
            double Total = Price + VAT;
            
            //Show in labels
            LBLshowPrice.Text = Price.ToString("0.00");
            LBLshowVAT.Text = PriceVAT.ToString("0.00");
            LBLshowTotal.Text = Total.ToString("0.00");
        }

    }
}
