using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.src
{
    abstract class PublicTransport
    {
        protected PublicTransport(int nowInTransport = 0)
        {
            NowInTransport = nowInTransport;
        }

        protected string Brand;
        public int Speed { get; protected set; }
        public int Capacity { get; protected set; }
        public int NowInTransport { get; protected set; }
        public Image Texture { get; protected set; }
        protected bool IsFilled = false;

        public void PutPassengers(int pass)
        {
            NowInTransport = (NowInTransport + pass >= Capacity) ? Capacity : NowInTransport + pass;
        }

        public string Info()
        {
            var info = $"{Brand}, свободно {Capacity - NowInTransport} мест.";
            return info;
        }
    }
}
