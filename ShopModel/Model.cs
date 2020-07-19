using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Model
    {
        private int countOfSellers;
        private int time;
        private int nameOfSeller;

        public Model()
        {
            countOfSellers = 0;
            time = 0;
            nameOfSeller = 0;
        }

        public event Action<int> LessCountOfSellers;
        public event Action<string[], int[]> MoreCountOfSellers;

        public void NewCountOfSellers(int count)
        {
            if (count < countOfSellers)
            {
                LessCountOfSellers(countOfSellers - count);
                countOfSellers = count;
            }
            if (count > countOfSellers)
            {
                var names = new string[count - countOfSellers];
                var speeds = new int[count - countOfSellers];
                for (int i = 0; i < count - countOfSellers; i++)
                {
                    names[i] = nameOfSeller.ToString();
                    nameOfSeller++;

                    speeds[i] = 1;
                }
                MoreCountOfSellers(names, speeds);
                countOfSellers = count;
            }
        }

        public void TimeChanged(int time)
        {
            this.time = time;
        }

        private string[] Products =
        {
            "Garlic",
            "Onion",
            "Olive oil",
            "Soy sauce",
            "Pepper",
            "Egg",
            "Salt",
            "Butter",
            "Flour",
            "Cheese",
            "Bacon"
        };

        private Purchase RandomPurchaseGenerator()
        {
            var rand = new Random();
            var productName = Products[rand.Next(0, Products.Length - 1)];
            var price = rand.Next(1, 100);
            return new Purchase(productName, price);
        }

        private Customer RandomCustomerGenerator()
        {
            var rand = new Random();
            var name = rand.Next(1, 50).ToString();
            var purchases = new Dictionary<Purchase, int>();
            var countOfPurchases = 0;
            while (countOfPurchases < 5)
            {
                var purchase = RandomPurchaseGenerator();
                if (purchases.ContainsKey(purchase))
                {
                    continue;
                }
                var count = rand.Next(1, 5);
                purchases.Add(purchase, count);
                countOfPurchases++;
            }
            return new Customer(name, purchases);
        }

        public void SpeedToCountOfPurchases(int[] speeds)
        {
            var countOfPurchases = new int[speeds.Length];
            for (int i = 0; i < speeds.Length; i++)
            {
                countOfPurchases[i] = speeds[i] * 60 * time;
            }
            ButtonClickedCalculate(countOfPurchases);
        }

        public event Action<int, int> OpenResultWindow;

        private void ButtonClickedCalculate(int[] countOfPurchases)
        {
            var profit = 0;
            var countOfCustomers = 0;
            foreach (var sellerTime in countOfPurchases)
            {
                var sellerCountOfPurchases = 0;
                while (true)
                {
                    var customer = RandomCustomerGenerator();
                    var customerCountOfPurchases = 0;
                    var customerProfit = 0;
                    foreach (KeyValuePair<Purchase, int> kvp in customer.Purchases)
                    {
                        customerCountOfPurchases += kvp.Value;
                        customerProfit += kvp.Key.Price * kvp.Value;
                    }
                    if (sellerTime < customerCountOfPurchases + sellerCountOfPurchases)
                    {
                        break;
                    }
                    sellerCountOfPurchases += customerCountOfPurchases;
                    profit += customerProfit;
                    countOfCustomers++;
                }
            }
            OpenResultWindow(countOfCustomers, profit);
        }
    }
}
