using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBNcalculate_Click(object sender, EventArgs e)
        {
            int Seconden = int.Parse(TXBseconds.Text); // geen seconden

            // aantal uuren
            int Uren = Seconden / 3600;

            // bereken overige seconde
            Seconden = Seconden - Uren * 3600;  // = seconden % 3600;

            // aantal minuten
            int Minuten = Seconden / 60;

            // bepaal overige seconden
            Seconden = Seconden - Minuten * 60; // = seconden % 60;

            // geen tijd weer

            string Tijd = $"{Uren:00}:{Minuten:00}:{Seconden:00}";
            LBLtime.Text = Tijd;
        }
    }
}
