using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp2.src;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Queue<PublicTransport> Transports = new Queue<PublicTransport>();
        private Random rand = new Random();
        private int People = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublicTransport transport = null;
            if (checkBox1.Checked == true)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        transport = new Bus();
                        break;
                    case 1:
                        transport = new Taxi();
                        break;
                    case 2:
                        transport = new Gazelle();
                        break;
                }
            }
            else
            {
                if (radioButton1.Checked == true) transport = new Bus();
                else if (radioButton2.Checked == true) transport = new Gazelle();
                else if (radioButton3.Checked == true) transport = new Taxi();
                else return;
            }
            pictureBox1.Image = null;
            pictureBox1.Image = transport.Texture;
            Transports.Enqueue(transport);
            label2.Text = People.ToString();
            var lv = new ListViewItem(Text = transport.Info());
            listView1.Items.Add(lv);

        }

        private void ChangePeopleAtState()
        {
            if (Transports.Count == 0) return;
            var transport = Transports.Peek();
            if (People >= transport.Capacity - transport.NowInTransport)
            {
                People -= (transport.Capacity - transport.NowInTransport);
                Transports.Dequeue();
                listView1.Items[0].Remove();

            }
            else
            {
                transport.PutPassengers(People);
                People = 0;
                listView1.Items[0].Text = transport.Info();
            }
            label2.Text = People.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) People += rand.Next(1, 51);
            else People += trackBar1.Value;
            label2.Text = People.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangePeopleAtState();
        }
    }
}
