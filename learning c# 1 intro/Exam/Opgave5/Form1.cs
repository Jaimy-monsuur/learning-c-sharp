using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNBerekenprijs_Click(object sender, EventArgs e)
        {
            double price = 0;
            int age = int.Parse(TXBAge.Text);

            if (RBTNAStarIsBorn.Checked)
            {
                price = 10.00;
            }
            else if (RBTNStrikesAgain.Checked)
            {
                price = 10.50;
            }
            else if (RBTNPeppermint.Checked)
            {
                price = 11.00;
            }

            if (age > 65)
            {
                price = price * 0.75; // dus 25% korting
            }
            LBLTeBetalen.Text = price.ToString("0.00");
        }
    }
}
