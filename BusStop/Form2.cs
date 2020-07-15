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

namespace BusStop
{
    public partial class Form2 : Form
    {

        private string[] busTypesList = { "GAZelle", "Peugeot", "Bus" };

        private int passengers = 0;

        public Form2()
        {
            InitializeComponent();

            listBox1.MultiColumn = false;
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Items.Clear();

            listBox2.MultiColumn = false;
            listBox2.SelectionMode = SelectionMode.None;
            listBox2.BeginUpdate();

            listBox2.Items.Clear();

            foreach (var busType in busTypesList)
            {
                listBox2.Items.Add($"{busType}: 0");
            }

            listBox2.EndUpdate();

            listBox3.MultiColumn = false;
            listBox3.SelectionMode = SelectionMode.None;
            listBox3.Items.Clear();

            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series.Add("Passengers");
            chart1.Series["Passengers"].ChartType = SeriesChartType.Line;
            chart1.Series["Passengers"].Color = Color.Red;
            chart1.Series.Add("Buses");
            chart1.Series["Buses"].ChartType = SeriesChartType.Line;
            chart1.Series["Buses"].Color = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int allTime;
            if (!int.TryParse(textBox1.Text, out allTime))
            {
                return;
            }
            if (allTime <= 0)
            {
                return;
            }
            double alpha;
            if (!double.TryParse(textBox2.Text, out alpha))
            {
                return;
            }
            if (alpha < 0)
            {
                return;
            }
            int gamma;
            if (!int.TryParse(textBox3.Text, out gamma))
            {
                return;
            }
            if (gamma <= 0)
            {
                return;
            }
            int normalRandMax;
            if (!int.TryParse(textBox4.Text, out normalRandMax))
            {
                return;
            }
            if (normalRandMax < 0)
            {
                return;
            }

            var rand = new Random();

            listBox1.Items.Clear();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.Items[i] = $"{listBox2.Items[i].ToString().Split()[0]} 0";
            }
            listBox3.Items.Clear();

            var chart = chart1.ChartAreas[0];

            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = allTime;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = allTime;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 1;

            chart1.Series["Passengers"].Points.Clear();
            chart1.Series["Buses"].Points.Clear();

            for (var time = 0; time <= allTime; time++)
            {
                var passengerRand = rand.Next(0, normalRandMax);
                if (passengerRand < normal(time, alpha))
                {
                    new_Passengers(rand.Next(1, 10), time);
                }

                var busRand = rand.NextDouble();
                if (busRand < exponential(time, gamma))
                {
                    new_Bus(rand.Next(0, 3), time);
                }

                chart1.Series["Passengers"].Points.AddXY(time, passengers);

                chart1.Series["Buses"].Points.AddXY(time, listBox3.Items.Count);
            }
        }

        private void new_Passengers(int count, int time)
        {
            passengers += count;

            listBox1.BeginUpdate();
            listBox1.Items.Add($"[{time}] {count} passengers arrived");
            listBox1.EndUpdate();

            label6.Text = $"{int.Parse(label6.Text) + count}";

            bus_Queue(time);
        }

        private void new_Bus(int index, int time)
        {
            Minibus bus;
            switch (index)
            {
                case 0:
                    bus = new Gazelle();
                    break;
                case 1:
                    bus = new Peugeot();
                    break;
                case 2:
                    bus = new Bus();
                    break;
                default:
                    return;
            }

            listBox1.BeginUpdate();
            listBox1.Items.Add($"[{time}] {busTypesList[index]}: arrived with capacity - {bus.capacity}");
            listBox1.EndUpdate();

            var parsedCountDisplay = listBox2.Items[index].ToString().Split();
            var newCount = int.Parse(parsedCountDisplay[1]) + 1;
            listBox2.Items[index] = $"{parsedCountDisplay[0]} {newCount}";

            listBox3.BeginUpdate();
            listBox3.Items.Add($"{parsedCountDisplay[0]} 0/{bus.capacity}");
            listBox3.EndUpdate();

            bus_Queue(time);
        }

        private void bus_Queue(int time)
        {
            if (listBox3.Items.Count == 0)
            {
                return;
            }
            var parsedCountDisplay = listBox3.Items[0].ToString().Split();
            var capacity = int.Parse(parsedCountDisplay[1].Split('/')[1]);

            if (passengers < capacity)
            {
                listBox3.Items[0] = $"{parsedCountDisplay[0]} {passengers}/{capacity}";
                return;
            }

            passengers -= capacity;

            listBox1.BeginUpdate();
            listBox1.Items.Add($"[{time}] {parsedCountDisplay[0]} leaved with capacity - {capacity}");
            listBox1.EndUpdate();

            listBox3.Items.RemoveAt(0);
            bus_Queue(time);
        }

        private double normal(int time, double alpha)
        {
            double first = 1 / Math.Sqrt(2 * Math.PI);
            double second = 1 / Math.Sqrt(Math.E);
            second = Math.Pow(second, (time - alpha) * (time - alpha));
            return first * second;

        }

        private double exponential(int time, int gamma)
        {
            return 1 - 1 / Math.Pow(Math.E, time * gamma);
        }
    }
}
