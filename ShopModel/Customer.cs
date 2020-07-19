using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Customer
    {
        public string Name { get; }
        public Dictionary<Purchase, int> Purchases { get; }

        public Customer(string name, Dictionary<Purchase, int> purchases)
        {
            Name = name;
            Purchases = purchases;
        }
    }
}
