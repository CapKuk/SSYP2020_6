using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static event Action<List<int> , int> CalculateClick;

        private void quantityBar_Scroll(object sender, EventArgs e)
        {
            if (quantityBar.Value >= int.Parse(quantity.Text))
            {
                for (var i = int.Parse(quantity.Text); i < quantityBar.Value; i++)
                {
                    var GroupBox = new GroupBox();
                    var label = new Label();
                    label.Text = "10";
                    label.Size = new Size(50, 30);
                    label.Location = new Point(250, 50);
                    GroupBox.Text = $"Скорость продавца № {i + 1}";
                    GroupBox.Size = new Size(350, 100);
                    GroupBox.Location = new Point(10, 80);
                    GroupBox.Controls.Add(label);
                    var trackBar = new TrackBar() { Width = durationBar.Width, Maximum = 20, Minimum = 5, Value = 10, Location = new Point(10, 50) };
                    trackBar.Scroll += (s, ee) => 
                    {
                        label.Text = trackBar.Value.ToString();
                    };
                    GroupBox.Controls.Add(trackBar);
                    flowLayout.Controls.Add(GroupBox);
                }
            }
            else
            {
                for (var i = 0; i < int.Parse(quantity.Text) - quantityBar.Value; i++) flowLayout.Controls.RemoveAt(flowLayout.Controls.Count - 1);
            }
            quantity.Text = quantityBar.Value.ToString();
        }

        private void durationBar_Scroll(object sender, EventArgs e)
        {
            duration.Text = durationBar.Value.ToString();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (quantityBar.Value == 0) return;
            var SellersSpeed = new List<int>();
            for (var i = 0; i < flowLayout.Controls.Count; i++)
            {
                var trBar = flowLayout.Controls[i].Controls[1] as TrackBar;
                SellersSpeed.Add(trBar.Value);
            }
            CalculateClick(SellersSpeed, durationBar.Value);

        }
    }
}
