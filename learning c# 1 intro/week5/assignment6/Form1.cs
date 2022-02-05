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
        const int ARRAYSIZE = 20;
        const int MAXNUMBER = 500;
        public Form1()
        {
            InitializeComponent();
        }

        int[] Numbers = new int[ARRAYSIZE];
        //staat buiten de void ander werkt het niet in beide.

        private void Form1_Load(object sender, EventArgs e)
        {
            // genereer random nummer lijst(0,500)
            //aray groote is 20

            //declaring stuff
            string list = "";

            Random Random = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Random.Next(0, MAXNUMBER);
                // heb een /N toegevoegd naadat ik er achter kwam dat hij alles op een lijn plaatste.
                list = list + $"Element {i} = {Numbers[i]}\n";
            }
            LBLtablestart.Text = list;
        }

        private void BTNcompare_Click(object sender, EventArgs e)
        {
            //declaring stuff
            int Comparisonnumber = 0;
            string list = "";

            //Comparison number is?
            Comparisonnumber = int.Parse(TXBinput.Text);

            //for loop with if else. tot determine +10 or -5
            for (int i = 0; i < Numbers.Length; i++)
            {
                 
                if (Numbers[i] >= Comparisonnumber)
                {
                    Numbers[i] += 10;
                }
                else
                {
                    Numbers[i] -= 5;
                }
                
                list = list + $"Element {i} = {Numbers[i]}\n";
            }
            LBLTablecompared.Text = list;
            BTNcompare.Enabled = false;
            
        }
    }
}
