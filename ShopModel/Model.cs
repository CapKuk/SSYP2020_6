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

        private int[] productsPrices = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        private Purchase RandomPurchaseGenerator()
        {
            var rand = new Random();
            var productIndex = rand.Next(0, Products.Length - 1);
            var productName = Products[productIndex];
            var price = 0;
            if (productsPrices[productIndex] == 0)
            {
                price = rand.Next(1, 100);
                productsPrices[productIndex] = price;
            }
            else
            {
                price = productsPrices[productIndex];
            }
            return new Purchase(productName, price);
        }

        private Customer RandomCustomerGenerator()
        {
            var rand = new Random();
            var name = rand.Next(1, 50).ToString();
            var purchases = new Dictionary<Purchase, int>();
            var countOfPurchases = 0;
            var maxCountOfPurchases = rand.Next(3, 7);
            while (countOfPurchases < maxCountOfPurchases)
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

        public void SpeedToCountOfPurchases(string[] names, int[] speeds)
        {
            var countOfPurchases = new int[speeds.Length];
            for (int i = 0; i < speeds.Length; i++)
            {
                countOfPurchases[i] = speeds[i] * 60 * time;
            }
            ButtonClickedCalculate(names, countOfPurchases);
        }

        public event Action OpenLogsWindow;
        public event Action<string> AddDataToLogs;
        public event Action<int, int> OpenResultWindow;

        private void ButtonClickedCalculate(string[] sellersNames, int[] countOfPurchases)
        {
            var profit = 0;
            var countOfCustomers = 0;
            OpenLogsWindow();
            for (int i = 0; i < countOfPurchases.Length; i++)
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
                    if (countOfPurchases[i] < customerCountOfPurchases + sellerCountOfPurchases)
                    {
                        break;
                    }
                    sellerCountOfPurchases += customerCountOfPurchases;
                    profit += customerProfit;
                    countOfCustomers++;
                    AddDataToLogs(CustomerDataToLogs(sellersNames[i], customer));
                }
            }
            OpenResultWindow(countOfCustomers, profit);
        }

        private string CustomerDataToLogs(string sellerName, Customer customer)
        {
            var text = $"Seller <{sellerName}>: New customer <{customer.Name}> with purchases ";
            foreach (KeyValuePair<Purchase, int> kvp in customer.Purchases)
            {
                text += $"{kvp.Key.Name}: {kvp.Key.Price}*{kvp.Value} ";
            }
            return text;
        }
    }
}
