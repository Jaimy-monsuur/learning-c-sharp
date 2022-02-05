using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNcalculate_Click(object sender, EventArgs e)
        {
            double value = double.Parse(TXBstart.Text);

            // had value = value * 1.05^5 niet ook kunnen werken? ipv een loop.
            for (int i = 0; i < 5; i++)
            {
                value = value * 1.05;
            }
            LBLoutput.Text = value.ToString("0.00");
        }
    }
}
