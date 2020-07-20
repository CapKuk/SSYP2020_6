using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForms
{
    class Seller
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public static List<string> SellerNames = new List<string>
        { "Петя", "Женя", "Гоша", "Катя", "Люда", "Ксюша", "Толя", "Семён", "Вова", "Марина" };

        public Seller(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
