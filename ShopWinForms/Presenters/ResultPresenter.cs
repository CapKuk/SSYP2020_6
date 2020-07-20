using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinForms
{
    class ResultPresenter : IPresenter
    {
        private Shop Model = null;
        private Form2 newWindow = new Form2();
        
        public ResultPresenter(Shop model)
        {
            Model = model;
            newWindow.progress.Maximum = model.DurationWorkDay + 1;
            Form2.TimerTick += SimulationOfWorkingHours;
        }

        private void SimulationOfWorkingHours()
        {
            if (Model.SimulationEnded)
            {
                newWindow.timer1.Enabled = false;
                return;
            }
            Model.SimulateOneHourWork();
            newWindow.count.Text = Model.ClientsProcessed.ToString();
            newWindow.profit.Text = Model.Profit.ToString();
            newWindow.progress.Value += 1;
        }

        public void Run()
        {
            newWindow.ShowDialog();
        }
    }
}
