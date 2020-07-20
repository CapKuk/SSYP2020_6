using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinForms
{
    class ResultPresenter : IPresenter
    {
        private int customers = 0;
        private int profit = 0;

        public ResultPresenter(int customers, int profit)
        {
            this.customers = customers;
            this.profit = profit;
        }

        public void Run()
        {
            var newWindow = new Form2();
            newWindow.count.Text = customers.ToString();
            newWindow.profit.Text = profit.ToString();
            newWindow.ShowDialog();
        }
    }
}
