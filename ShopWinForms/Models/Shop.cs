using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForms
{
    class Shop
    {
        public Shop(List<int> speeds, int duration)
        {
            DurationWorkDay = duration;
            PutUpSellers(speeds);
        }

        private void GenerateCustomersForCashier()
        {
            var count = rand.Next(3, 15) * DurationWorkDay;
            for (var i = 0; i < count; i++)
            {
                MinimumQueue().Customers.Enqueue(Customer.GenrateRandomCustomer());
            }
        }

        private Cashier MinimumQueue()
        {
            int minQueue = Cashiers.Min(i => i.Customers.Count);
            foreach (var i in Cashiers)
            {
                if (i.Customers.Count == minQueue)
                {
                    return i;
                }
            }
            return null;
        }

        private void PutUpSellers(List<int> speeds)
        {
            for (int i = 0; i < speeds.Count; i++)
            {
                Cashiers.Add(new Cashier(new Seller(Seller.SellerNames[rand.Next(0, 10)], speeds[i])));
            }
        }

        public void SimulateOneHourWork()
        {
            if (TimeNow < DurationWorkDay)
            {
                TimeNow++;
                for (var i = 0; i < Cashiers.Count; i++)
                {
                    GenerateCustomersForCashier();
                    foreach (var cashier in Cashiers)
                    {
                        cashier.CalculateClientsOneHour();
                    }
                    ChangeProfit();
                    ChangeClientsProcessed();
                }
                return;
            }
            SimulationEnded = true;
        }

        private void ChangeProfit()
        {
            Profit = 0;
            foreach (var cashier in Cashiers) Profit += cashier.profit;
        }

        private void ChangeClientsProcessed()
        {
            ClientsProcessed = 0;
            foreach (var cashier in Cashiers) ClientsProcessed += cashier.ClientsProcessed;
        }

        public int ClientsProcessed = 0;
        public int Profit = 0;
        public Random rand = new Random();
        public List<Cashier> Cashiers = new List<Cashier>();
        public int DurationWorkDay { get; set; }
        private double TimeNow = 0;
        public bool SimulationEnded = false;

    }
}
