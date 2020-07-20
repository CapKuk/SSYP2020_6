using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForms
{
    internal class Customer
    {
        public string Name { get; set; }
        public Dictionary<Purchase, int> CheckList = new Dictionary<Purchase, int>();
        public static List<string> CustomerNames = new List<string> { "Сергей", "Настя", "Маша", "Кирилл", "Антон", "Гена" };
        public static Random rand = new Random();


        public Customer(string name)
        {
            Name = name;
        }

        public static Customer GenrateRandomCustomer()
        {
            Purchase pr = null;
            int count = 0;
            var cstmr = new Customer(CustomerNames[rand.Next(0, CustomerNames.Count)]);
            var countPurchase = rand.Next(1, 10);
            for (var i = 0; i < countPurchase; i++)
            {
                try
                {
                    pr = Purchase.GenerateRandomPurchase();
                    count = rand.Next(1, 4);
                    cstmr.CheckList.Add(pr, count);
                }
                catch
                {
                    cstmr.CheckList[pr] += count;
                }
            }
            return cstmr;
        }
    }
}
