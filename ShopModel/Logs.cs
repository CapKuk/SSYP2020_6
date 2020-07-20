using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModel
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();

            listBox1.MultiColumn = false;
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Items.Clear();
        }

        public void AddDataToLogs(string text)
        {
            listBox1.BeginUpdate();
            listBox1.Items.Add(text);
            listBox1.EndUpdate();
        }
    }
}
