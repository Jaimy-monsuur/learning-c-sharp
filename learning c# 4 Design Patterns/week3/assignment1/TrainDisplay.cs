using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        public TrainDisplay(int count)
        {
            InitializeComponent();
            this.Text = $"TrainDisplay #{count}";
            this.Show();
        }

        public void GetUpdate(TrainStation trainStation)
        {
            LBL_name.Text = trainStation.name;
            LBL_track.Text = trainStation.arrival_track;
        }
    }
}
