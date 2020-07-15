using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStop
{
    class Gazelle : Minibus
    {
        public Gazelle() : base()
        {
            var rand = new Random();
            capacity = rand.Next(8, 14);
        }
    }
}
