using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp2.src;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private Queue<PublicTransport> Transports = new Queue<PublicTransport>();
        private Random rand = new Random();
        private int People = 0;
        private int Time = 0;
        private int TimeNow = 1;

        public Form2()
        {
            InitializeComponent();

            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series.Add("Пассажиры");
            chart1.Series["Пассажиры"].ChartType = SeriesChartType.Line;
            chart1.Series["Пассажиры"].Color = Color.Red;
            chart1.Series.Add("Транспорт");
            chart1.Series["Транспорт"].ChartType = SeriesChartType.Line;
            chart1.Series["Транспорт"].Color = Color.Blue;
        }

        private double exp(int time, int gamma)
        {
            return 1 - 1 / Math.Pow(Math.E, time * gamma);
        }

        private double normal(int time, double alpha)
        {
            var number1 = 1 / Math.Sqrt(2 * Math.PI);
            var number2 = 1 / Math.Sqrt(Math.E);
            var number3 = Math.Pow(number2, (time - alpha) * (time - alpha));
            return number1 * number3;

        }

        private void durationBar_Scroll(object sender, EventArgs e)
        {
            label5.Text = durationBar.Value.ToString();
        }

        private void AlphaBar_Scroll(object sender, EventArgs e)
        {
            label6.Text = AlphaBar.Value.ToString();
        }

        private void GammaBar_Scroll(object sender, EventArgs e)
        {
            label7.Text = GammaBar.Value.ToString();
        }

        private void randBar_Scroll(object sender, EventArgs e)
        {
            label8.Text = randBar.Value.ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chart1.Series["Транспорт"].Points.Clear();
            chart1.Series["Пассажиры"].Points.Clear();
            Time = durationBar.Value;
            timer1.Enabled = true;
            progressBar1.Maximum = Time;
            randBar.Enabled = false;
            durationBar.Enabled = false;
            AlphaBar.Enabled = false;
            GammaBar.Enabled = false;
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeNow == Time)
            {
                timer1.Enabled = false;
                Default();
                return;
            }
            if (rand.Next(0, randBar.Value) < normal(TimeNow, AlphaBar.Value))
            {
                People += rand.Next(0, 15);
                peopleCount.Text = People.ToString();
            }
            if (rand.NextDouble() < exp(TimeNow, GammaBar.Value))
            {
                PublicTransport trans = null;
                switch (rand.Next(0, 3))
                {
                    case 0:
                        trans = new Bus();
                        break;
                    case 1:
                        trans = new Taxi();
                        break;
                    case 2:
                        trans = new Gazelle();
                        break;
                }
                var lv = new ListViewItem(Text = trans.Info());
                listViewTransport.Items.Add(lv);
                Transports.Enqueue(trans);
            }
            chart1.Series["Пассажиры"].Points.AddXY(TimeNow, People);
            chart1.Series["Транспорт"].Points.AddXY(TimeNow, Transports.Count);
            DistributePassengers();
            TimeNow++;
            progressBar1.Value = TimeNow;
        }

        private void DistributePassengers()
        {
            while (People != 0 && Transports.Count != 0)
            {
                ChangePeopleAtState();
            }
        }

        private void ChangePeopleAtState()
        {
            var transport = Transports.Peek();
            if (People >= transport.Capacity - transport.NowInTransport)
            {
                People -= (transport.Capacity - transport.NowInTransport);
                Transports.Dequeue();
                listViewTransport.Items[0].Remove();

            }
            else
            {
                transport.PutPassengers(People);
                People = 0;
                listViewTransport.Items[0].Text = transport.Info();
            }
        }

        private void Default()
        {
            randBar.Enabled = true;
            durationBar.Enabled = true;
            AlphaBar.Enabled = true;
            GammaBar.Enabled = true;
            startButton.Enabled = true;

            People = 0;
            Transports = new Queue<PublicTransport>();
            TimeNow = 1;
        }
    }
}
