using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht9
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        const double football = 175;
        const double handball = 225;

        private void BTNfee_Click(object sender, EventArgs e)
        {
            //input
            String memberage = TXBage.Text;
            String memberduration = TXBduration.Text;

            // naar double
            double age = double.Parse(memberage);
            double duration = double.Parse(memberduration);
            double fee1 = football;
            double fee2 = handball;

            if (RBTNfoorball.Checked)
            {
                if (age >= 40)
                {
                    fee1 = fee1 - 25;
                }
                if (duration >= 10)
                {
                    fee1 = fee1 - 20;
                }
                LBLfee.Text = fee1.ToString("0.00");
            }

            if (RBTNhandball.Checked)
            {
                if (age >= 40)
                {
                    fee2 = fee2 - 25;
                }
                if (duration >= 10)
                {
                    fee2 = fee2 - 20;
                }
                LBLfee.Text = fee2.ToString("0.00");
            }

            Console.ReadKey();
        }
    }
}
