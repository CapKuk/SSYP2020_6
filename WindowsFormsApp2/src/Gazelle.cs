using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.src
{
    class Gazelle : PublicTransport
    {
        public Gazelle(int nowInTransport = 0) : base(nowInTransport)
        {
            Texture = Properties.Resources.gazel;
            Capacity = 12;
            Speed = 70;
        }
    }
}
