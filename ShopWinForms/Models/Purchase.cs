using System;
using System.Collections.Generic;

namespace ShopWinForms
{
    internal class Purchase
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public static List<Purchase> PurchaseSet = new List<Purchase>
        {new Purchase("Хлеб", 50), new Purchase("Молоко", 60), new Purchase("Вода", 30), new Purchase("Яйца", 40), new Purchase("Печенье", 100)};
        public static short SetCount = 5;
        public static Random rand = new Random();

        public Purchase(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public static Purchase GenerateRandomPurchase()
        {
            return PurchaseSet[rand.Next(0, SetCount)];
        }

        public string Info()
        {
            return $"Продукт: {Name}, по цене {Price}";
        }
    }
}