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

        public static event Action<int, int , int> CalculateClick;

        private void quantityBar_Scroll(object sender, EventArgs e)
        {
            quantity.Text = quantityBar.Value.ToString();
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            speed.Text = speedBar.Value.ToString();
        }

        private void durationBar_Scroll(object sender, EventArgs e)
        {
            duration.Text = durationBar.Value.ToString();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            CalculateClick(quantityBar.Value, speedBar.Value, durationBar.Value);
        }
    }
}
