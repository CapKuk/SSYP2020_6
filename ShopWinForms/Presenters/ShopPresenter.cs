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
        public static event Action<int, int> ResultReceived;
        private Shop Model;
        public (int, int) result;

        public ShopPresenter()
        {
            MakeBindings();
        }

        private void MakeBindings()
        {
            Form1.CalculateClick += Calculate;
        }

        private void Calculate(int sellersCount, int speed, int duration)
        {
            CreateModel(sellersCount, speed, duration);
            result = Model.ServiceResults();
            ResultReceived(result.Item1, result.Item2);
        }
        private void CreateModel(int sellersCount, int speed, int duration)
        {
            Model = new Shop(duration, sellersCount, speed);
        }

        public void Run()
        {
            Application.Run(new Form1());
        }
    }
}
