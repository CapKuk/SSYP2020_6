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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Action<int> SellersCountChanged;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SellersCountChanged(Decimal.ToInt32(numericUpDown1.Value));
        }

        public void AddCountOfSellers(string[] names, int[] speeds)
        {
            var count = Math.Min(names.Length, speeds.Length);
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(names[i], speeds[i]);
            }
        }

        public void RemoveCountOfSellers(int count)
        {
            var maxCount = dataGridView1.Rows.Count;
            for (int i = 0; i < Math.Min(count, maxCount); i++)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }
        }


        public event Action<int> TimeChanged;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out var time))
            {
                TimeChanged(time);
            }
        }


        public event Action<string[], int[]> ButtonClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            var sellersName = new string[dataGridView1.Rows.Count];
            var sellersSpeed = new int[dataGridView1.Rows.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                sellersName[row.Index] = row.Cells[0].Value.ToString();

                if (!int.TryParse(row.Cells[1].Value.ToString(), out sellersSpeed[row.Index]))
                {
                    return;
                }
                if (sellersSpeed[row.Index] < 0)
                {
                    return;
                }
            }
            ButtonClicked(sellersName, sellersSpeed);
        }
    }
}
