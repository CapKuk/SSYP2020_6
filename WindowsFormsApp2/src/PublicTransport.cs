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

        public int Speed { get; protected set; }
        public int Capacity { get; protected set; }
        public int NowInTransport { get; protected set; }
        public Image Texture { get; protected set; }
        protected bool IsFilled = false;

        public int PutPassengers(int pass)
        {
            if (Capacity - NowInTransport <= pass)
            {
                IsFilled = true;
                return pass - (Capacity - NowInTransport);
            }
            else
            {
                NowInTransport += pass;
                return 0;
            }
        }
    }
}
