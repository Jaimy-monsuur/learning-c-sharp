using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNaverage_Click(object sender, EventArgs e)
        {
            //input number 1,2,3
            double NO1 = double.Parse(TBXno1.Text);
            double NO2 = double.Parse(TBXno2.Text);
            double NO3 = double.Parse(TBXno3.Text);
            //Average is
            double Average = (NO1 + NO2 + NO3) / 3;

            LBLanswer.Text = Average.ToString("0.000"); 


        }
    }
}
