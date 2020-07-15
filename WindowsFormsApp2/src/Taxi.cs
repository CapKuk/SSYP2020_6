using System.Drawing;

namespace WindowsFormsApp2.src
{
    class Taxi : PublicTransport
    {
        public Taxi(int nowInTransport = 0) : base(nowInTransport)
        {
            Texture = Properties.Resources.taxi;
            Capacity = 5;
            Speed = 120;
        }
    }
}
