using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinForms
{
    class ShopPresenter : IPresenter
    {
        public static event Action<Shop> ResultReceived;
        private Shop Model;

        public ShopPresenter()
        {
            MakeBindings();
        }

        private void MakeBindings()
        {
            Form1.CalculateClick += Calculate;
        }

        private void Calculate(List<int> speeds, int duration)
        {
            CreateModel(speeds, duration);
            ResultReceived(Model);
        }
        private void CreateModel(List<int> speeds, int duration)
        {
            Model = new Shop(speeds, duration);
        }

        public void Run()
        {
            Application.Run(new Form1());
        }
    }
}
