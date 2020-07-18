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
        private int EventTime = 1;

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
            randBar.Enabled = false;
            durationBar.Enabled = false;
            AlphaBar.Enabled = false;
            GammaBar.Enabled = false;
            startButton.Enabled = false;
            CoeffBar.Enabled = false;
            for (var i = 0; i < durationBar.Value; i++)
            {
                CreateAndDoEvent();
            }
            Default();
        }

        private void CreateAndDoEvent()
        {
            var newEventTime = EventTime;
            Event newEvent = RandomEvent();
            if (newEvent == Event.PassegerCame)
            {
                newEventTime = EventTime + Math.Abs((int)(normal(EventTime, AlphaBar.Value) * CoeffBar.Value * 100));
                newEventTime = (newEventTime == EventTime) ? newEventTime + 1 : newEventTime;
                People += rand.Next(5, 20);
                PeopleLb.Text = People.ToString();
                
            }
            else if (newEvent == Event.TransportArrived)
            {
                newEventTime = EventTime + Math.Abs((int)(exp(EventTime, GammaBar.Value) * CoeffBar.Value));
                newEventTime = (newEventTime == EventTime) ? newEventTime + 1 : newEventTime;
                Transports.Enqueue(RandomTransport());
            }
            else return;

            for (var i = EventTime; i < newEventTime; i++)
            {
                chart1.Series["Транспорт"].Points.AddXY(i, Transports.Count);
                chart1.Series["Пассажиры"].Points.AddXY(i, People);
            }
            EventTime = newEventTime;
        }

        private Event RandomEvent()
        {
            var newEvent = rand.Next(0, 2);
            return (newEvent == (int)Event.PassegerCame) ? Event.PassegerCame : Event.TransportArrived;
        }

        private PublicTransport RandomTransport()
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
            return trans;
        }

        private void Default()
        {
            randBar.Enabled = true;
            durationBar.Enabled = true;
            AlphaBar.Enabled = true;
            GammaBar.Enabled = true;
            startButton.Enabled = true;
            CoeffBar.Enabled = true;
            Transports = new Queue<PublicTransport>();
            People = 0;
            EventTime = 0;
        }

        private void CoeffBar_Scroll(object sender, EventArgs e)
        {
            Coeff.Text = CoeffBar.Value.ToString();
        }
    }
}
