using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForms
{
    class Shop
    {
        public Shop(int durationWorkDay, int SellersCount, int SellersSpeed)
        {
            DurationWorkDay = durationWorkDay;
            PutUpSellers(SellersCount, SellersSpeed);
            GenerateCustomes();
        }

        private void GenerateCustomes()
        {
            var count = rand.Next(3, 15) * DurationWorkDay;
            for (var i = 0; i < count; i++)
            {
                CustomerTurn.Enqueue(Customer.GenrateRandomCustomer());
            }
        }

        private void PutUpSellers(int sellersCount, int sellersSpeed)
        {
            for (int i = 0; i < sellersCount; i++)
            {
                Sellers.Add(new Seller(Seller.SellerNames[rand.Next(0, 10)], sellersSpeed));
            }
        }

        public Random rand = new Random();
        public List<Seller> Sellers = new List<Seller>();
        public int DurationWorkDay { get; set; }
        private Queue<Customer> CustomerTurn = new Queue<Customer>();

        public (int, int) ServiceResults()
        {
            var profit = 0;
            var overallSpeed = CalculateTheTotalSpeedOfSellers();
            double time = 0;
            int customers = 0;
            while (time < DurationWorkDay && CustomerTurn.Count != 0)
            {
                var res = ServiceTime(CustomerTurn.Dequeue(), overallSpeed);
                time += res.Item1;
                profit += res.Item2;
                customers += 1;
            }
            return (customers, profit);
        }

        private int CalculateTheTotalSpeedOfSellers()
        {
            var result = 0;
            Sellers.ForEach(i => result += i.Speed);
            return result;
        }

        private (double, int) ServiceTime(Customer customer, int overallSpeed)
        {
            var profit = 0;
            var items = 0;
            foreach (KeyValuePair<Purchase, int> entry in customer.CheckList)
            {
                items += entry.Value;
                profit += entry.Value * entry.Key.Price;
            }
            return ((double)items / overallSpeed, profit);
        }
    }
}
