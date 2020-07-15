using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStop
{
    class Bus : Minibus
    {
        public Bus() : base()
        {
            var rand = new Random();
            capacity = rand.Next(0, 30);
        }
    }
}
