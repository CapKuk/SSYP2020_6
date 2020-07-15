using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.src
{
    class Bus : PublicTransport
    {
        public Bus(int nowInTransport = 0) : base(nowInTransport)
        {
            Texture = Properties.Resources.bus;
            Capacity = 30;
            Speed = 60;
        }
    }
}
