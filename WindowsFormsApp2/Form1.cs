using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp2.src;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private PublicTransport Transport = null;
        private List<PublicTransport> RandTrans = new List<PublicTransport>()
        { new Taxi(), new Bus(), new Gazelle()};
        private Random rand = new Random();
        private int People = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Transport = RandTrans[rand.Next(0, 3)]; 
            }
            else
            {
                if (radioButton1.Checked == true) Transport = new Bus();
                if (radioButton2.Checked == true) Transport = new Gazelle();
                if (radioButton3.Checked == true) Transport = new Taxi();
            }
            People = Transport.PutPassengers(People);
            pictureBox1.Image = null;
            pictureBox1.Image = Transport.Texture;
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
    }
}
