using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStop
{
    class Peugeot : Minibus
    {
        public Peugeot() : base()
        {
            var rand = new Random();
            capacity = rand.Next(3, 18);
        }
    }
}
