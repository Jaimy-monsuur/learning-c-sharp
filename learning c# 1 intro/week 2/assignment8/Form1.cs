using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNcalculate_Click(object sender, EventArgs e)
        {
            //constane
            const double PRICEPERSHIRT = 30;
            const double PRICEPERJEANS = 100;
            const double VAT = 0.21;

            //input naar double

            double Priceshirt = PRICEPERSHIRT * double.Parse(TXBtshirts.Text);
            double Pricejeans = PRICEPERJEANS * double.Parse(TXBjeans.Text);


            double Price = Priceshirt + Pricejeans;
            double PriceVAT = Price * VAT;
            double Pricetotal = PriceVAT + Price;

            // show when button is pressed
            LBLdate.Text = (DateTime.Now).ToString();
            LBLprice.Text = Price.ToString("€ 0.00");
            LBLVAT.Text = PriceVAT.ToString("€ 0.00");
            LBLtatalprice.Text = Pricetotal.ToString("€ 0.00");


        }
    }
}
