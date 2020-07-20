using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForms
{
    class Cashier
    {
        public Seller Seller;
        public Queue<Customer> Customers = new Queue<Customer>();
        public int profit = 0;
        public int ClientsProcessed = 0;

        public Cashier(Seller seller)
        {
            Seller = seller;
        }

        public int CalculateClientsOneHour()
        {
            var itemsSold = 0;
            var deleted = new List<Purchase>();
            while (Seller.Speed > itemsSold)
            {
                foreach (var entry in Customers?.Peek()?.CheckList)
                {
                    if (Seller.Speed == itemsSold) return ClientsProcessed;
                    profit += (entry.Key.Price * entry.Value);
                    itemsSold++;
                    deleted.Add(entry.Key);
                }
                foreach (var i in deleted) Customers.Peek().CheckList.Remove(i);
                Customers?.Dequeue();
                ClientsProcessed++;
            }
            return ClientsProcessed;
        }

    }
}
