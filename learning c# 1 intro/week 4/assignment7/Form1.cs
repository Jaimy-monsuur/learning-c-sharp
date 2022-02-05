using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        const string CROS = "X";
        const string SPACE = " ";
        const string NEWLINE = "\n";
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNcreate_Click(object sender, EventArgs e)
        {
            int Size, Ver, Hor;
            Size = int.Parse(TXBinput.Text);
            string Square = "";

            for (Ver = 1; Ver <= Size; Ver++)
            {
                for (Hor = 1; Hor <= Size; Hor++)
                {
                    if ((Ver == 1) || (Ver == Size) || (Hor == 1) || (Hor == Size))
                    {
                        Square = Square + CROS;
                    }
                    else
                    {
                        Square = Square + SPACE;
                    }
                }
                Square = Square + NEWLINE;
            }
            LBLsquere.Text = Square;
        }
    }
}
