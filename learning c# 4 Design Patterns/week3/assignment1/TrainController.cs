using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class TrainController : Form
    {
        public ITrainJourney journey;
        public int displaycount = 0;
        public TrainController(ITrainJourney journey )
        {
            InitializeComponent();
            this.journey = journey;
            displaycount++;
            ITrainDisplay d = new TrainDisplay(displaycount);
            journey.AddObserver(d);
        }

        private void BTN_next_Click(object sender, EventArgs e)
        {
            journey.Next_Train();
        }

        private void BTB_newDisplay_Click(object sender, EventArgs e)
        {
            displaycount++;
            ITrainDisplay d = new TrainDisplay(displaycount);
            journey.AddObserver(d);
        }
    }
}
