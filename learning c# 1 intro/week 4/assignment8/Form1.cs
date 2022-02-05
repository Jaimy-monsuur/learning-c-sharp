using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNcompare_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TXBinput.Text);

            int som1 = 0;
            int getal = 1;

            while (getal <= n)
            {
                som1 = som1 + getal;
                getal++;
            }

            int som2 = n * (n + 1) / 2;

            //laat resultaat zien
            LBLawnser1.Text = som1.ToString();
            LBLawnser2.Text = som2.ToString();

            if (som1 == som2)
            {
                LBLawnser3.Text = ("The sum and folmula are equal");
            }
            else
            {
                LBLawnser3.Text = ("The sum and folmula are not equal");
            }
        }
    }
}
