using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] busTypesList = { "GAZelle", "Peugeot", "Bus" };

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.MultiColumn = false;
            listBox1.SelectionMode = SelectionMode.One;
            listBox1.BeginUpdate();

            listBox1.Items.Clear();

            foreach (var busType in busTypesList)
            {
                listBox1.Items.Add(busType);
            }

            listBox1.EndUpdate();

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oldPassengers = int.Parse(label2.Text);
            var allPassengers = int.Parse(label6.Text);
            int newPassengers;
            if (checkBox1.Checked)
            {
                var rand = new Random();
                newPassengers = rand.Next(1, 10);
                label2.Text = (oldPassengers + newPassengers).ToString();
                label6.Text = (allPassengers + newPassengers).ToString();
                bus_Queue();
                return;
            }

            var input = textBox1.Text;
            if (int.TryParse(input, out newPassengers))
            {
                if ((newPassengers > 20) || (newPassengers < 1))
                {
                    return;
                }
                label2.Text = (oldPassengers + newPassengers).ToString();
                label6.Text = (allPassengers + newPassengers).ToString();
                bus_Queue();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var busIndex = 0;
            if (checkBox2.Checked)
            {
                var rand = new Random();
                busIndex = rand.Next(0, 2);
            }
            else
            {
                busIndex = listBox1.TopIndex;
            }

            new_Bus(busIndex);
        }

        private void new_Bus(int index)
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
            var parsedCountDisplay = listBox2.Items[index].ToString().Split();
            var newCount = int.Parse(parsedCountDisplay[1]) + 1;
            listBox2.Items[index] = $"{parsedCountDisplay[0]} {newCount}";

            listBox3.BeginUpdate();
            listBox3.Items.Add($"{parsedCountDisplay[0]} 0/{bus.capacity}");
            listBox3.EndUpdate();
            bus_Queue();
        }

        private void bus_Queue()
        {
            if (listBox3.Items.Count == 0)
            {
                return;
            }
            var parsedCountDisplay = listBox3.Items[0].ToString().Split();
            var capacity = int.Parse(parsedCountDisplay[1].Split('/')[1]);
            var oldPassengers = int.Parse(label2.Text);

            if (oldPassengers < capacity)
            {
                listBox3.Items[0] = $"{parsedCountDisplay[0]} {oldPassengers}/{capacity}";
                return;
            }

            label2.Text = $"{oldPassengers - capacity}";
            listBox3.Items.RemoveAt(0);
            bus_Queue();
        }
    }
}
