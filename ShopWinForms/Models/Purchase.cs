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

        public Purchase(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public static Purchase GenerateRandomPurchase()
        {
            var rand = new Random();
            return PurchaseSet[rand.Next(0, PurchaseSet.Count)];
        }
    }
}