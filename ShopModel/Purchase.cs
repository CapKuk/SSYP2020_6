using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Purchase
    {
        public string Name { get; }
        public int Price { get; }

        public Purchase(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
