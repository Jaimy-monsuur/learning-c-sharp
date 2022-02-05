using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms.DataVisualization.Charting;

namespace MongodbChartWorkshop
{
    public partial class Form1 : Form
    {
        public List<BsonDocument> l;
        public Form1()
        {
            InitializeComponent();
        }
        public void Getdata()
        {
            DAL dal = new DAL();
            l = dal.GetCollecction("time_series_covid19_confirmed");
            foreach (BsonDocument b in l)
            {
                if (b[2].ToString().All(char.IsLetter) == true)
                {
                    string com = b[1] + ": " + b[2];
                    comboBox1.Items.Add(com);
                    comboBox2.Items.Add(com);
                }
                else
                {
                    comboBox1.Items.Add(b[1]);
                    comboBox2.Items.Add(b[1]);
                }

            }
        }

		//fillChart method  
		private void fillChart(BsonDocument b , string name)
		{
            
            //AddXY value in chart1 in series named as Confirmed m-d-Y
            
            foreach (BsonElement element in b)
            {
                if (element.Name.ToString().Contains("20") || element.Name.ToString().Contains("21"))
                {
                    string date = element.Name;
                    int number = element.Value.ToInt32();
                    chart1.Series["Corona Cases " + name].Points.AddXY(date, number);
                    chart1.Series["Corona Cases " + name].ChartType = SeriesChartType.Line;
                }
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
            LBL_TITLE.Text = ("Confirmed Corona Cases Chart in " + name);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                chart1.Series.Clear();
                if (comboBox1.Text.Contains(":"))
                {
                    string[] temp = comboBox1.Text.Split(':');
                    foreach (BsonDocument b in l)
                    {
                        if (b[1] == temp[0])
                        {
                            chart1.Series.Add("Corona Cases " + temp[0]);
                            fillChart(b, temp[0]);
                            break;
                        }
                    }

                }
                else
                {
                    foreach (BsonDocument b in l)
                    {
                        if (b[1] == comboBox1.Text)
                        {
                            chart1.Series.Add("Corona Cases " + b[1].ToString());
                            fillChart(b, b[1].ToString());
                            break;
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != null)
            {
                if (comboBox2.Text.Contains(":"))
                {
                    string[] temp = comboBox2.Text.Split(':');
                    foreach (BsonDocument b in l)
                    {
                        if (b[1] == temp[0])
                        {
                            chart1.Series.Add("Corona Cases " + temp[0]);
                            fillChart(b, temp[0]);
                            break;
                        }
                    }

                }
                else
                {
                    foreach (BsonDocument b in l)
                    {
                        if (b[1] == comboBox2.Text)
                        {
                            chart1.Series.Add("Corona Cases " + b[1].ToString());
                            fillChart(b, b[1].ToString());
                            break;
                        }
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
    }
}
