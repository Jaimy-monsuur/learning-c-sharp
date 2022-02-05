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
        const int DICESIZE = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNthrow_Click(object sender, EventArgs e)
        {
            string list = "";
            int[] dice = new int[DICESIZE];

            Random Random = new Random();
            for (int i = 0; i < 6000; i++)
            {
                int number = Random.Next(1, 7);
                dice[number -1]++;
                // volgens mij doet het nu wat het zou moeten doen?
            }

            for (int i = 0; i < 6; i++)
            {
                int number = dice[i];
                list = list + $"Number of thorws of value {i + 1} = {number}\n";
                
            }
            LBLlist.Text = list;
        }
    }
}
