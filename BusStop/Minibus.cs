using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStop
{
    class Minibus
    {
        public int capacity;
        public Minibus()
        {
            var rand = new Random();
            capacity = rand.Next(0, 30);
        }
    }
}
