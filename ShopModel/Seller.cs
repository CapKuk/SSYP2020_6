using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Seller
    {
        public string Name { get; }
        public int Speed { get; }

        public Seller(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
