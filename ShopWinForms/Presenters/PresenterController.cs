using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForms
{
    class PresenterController : IPresenter
    {

        public PresenterController()
        {
            ShopPresenter.ResultReceived += RunSecondWindow;
        }

        public void Run()
        {
            var firstWindow = new ShopPresenter();
            firstWindow.Run();
        }

        private void RunSecondWindow(int customers, int profit)
        {
            var secondWindow = new ResultPresenter(customers, profit);
            secondWindow.Run();
        }
    }
}
