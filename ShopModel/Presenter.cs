using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Presenter
    {
        public Form1 Form;
        private Model MainModel;

        private Logs LogsWindow;

        public Presenter()
        {
            Form = new Form1();
            MainModel = new Model();
            LogsWindow = new Logs();

            Form.SellersCountChanged += MainModel.NewCountOfSellers;
            MainModel.LessCountOfSellers += Form.RemoveCountOfSellers;
            MainModel.MoreCountOfSellers += Form.AddCountOfSellers;

            Form.TimeChanged += MainModel.TimeChanged;

            Form.ButtonClicked += MainModel.SpeedToCountOfPurchases;

            MainModel.OpenLogsWindow += OpenLogsWindow;
            MainModel.AddDataToLogs += LogsWindow.AddDataToLogs;

            MainModel.OpenResultWindow += OpenResult;
        }

        private void OpenLogsWindow()
        {
            LogsWindow.Show();
        }

        private void OpenResult(int count, int profit)
        {
            var resultWindow = new Form2();
            resultWindow.SetParams(count, profit);
            resultWindow.Show();
        }
    }
}
