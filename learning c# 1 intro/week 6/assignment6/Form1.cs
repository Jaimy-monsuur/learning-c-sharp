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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void BTNsquarebyreference_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TBXnumber.Text);
            SquareByReference(ref number);
            LBLresult.Text = number.ToString();
        }

        private void BTNsquarebyreferenceout_Click(object sender, EventArgs e)
        {
            int square;
            int number = int.Parse(TBXnumber.Text);
            SquareByReferenceOut(number, out square);
            LBLresult.Text = square.ToString();
        }

        private void BTNsquarebyvalue_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TBXnumber.Text);
            
            LBLresult.Text = SquareByValue(number).ToString();
        }
        void SquareByReference(ref int number)
        {
            number = number * number;
            return;
        }

        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
            return;
        }

        int SquareByValue(int number)
        {
            number = number * number;
            return number;
        }

    }
}
