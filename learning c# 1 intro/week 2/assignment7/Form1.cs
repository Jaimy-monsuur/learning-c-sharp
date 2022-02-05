using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double VAT = 0.21;
        private void BTNcalculate_Click(object sender, EventArgs e)
        {
            //Save input as
            double Start_km = double.Parse(TXBstartkm.Text);
            double End_km = double.Parse(TXBendkm.Text);
            double Price_km = double.Parse(TXBpricekm.Text);

            //calculate difference km
            double difference = End_km - Start_km;

            //calculate price excl VAT, VAT, price incl VAT
            double Price_excl_VAT = difference * Price_km;
            double VAT_Price = Price_excl_VAT * VAT;
            double Price_incl_VAT = Price_excl_VAT + VAT_Price;

            //show price in labels
            LBLpriceexclVAT.Text = Price_excl_VAT.ToString("0.00");
            LBLVAT.Text = VAT_Price.ToString("0.00");
            LBLpriceinclVAT.Text = Price_incl_VAT.ToString("0.00");

        }

        private void BTNerase_Click(object sender, EventArgs e)
        {

            TXBendkm.Clear();
            TXBstartkm.Clear();
            TXBpricekm.Clear();

            LBLpriceexclVAT.Text = string.Empty;
            LBLpriceinclVAT.Text = string.Empty;
            LBLVAT.Text = string.Empty;
        }
    }
}
