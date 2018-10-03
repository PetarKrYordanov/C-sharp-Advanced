using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }
                var inputArgs = input
                    .Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                StoreShopItems(inputArgs, shops);
            }
            PrintResult(shops);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, decimal>> shops)
        {
            foreach (var shop in shops.OrderBy(e=>e.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value.ToString("G29")}");
                }
            }
        }

        private static void StoreShopItems(string[] inputArgs, Dictionary<string, Dictionary<string, decimal>> shops)
        {
            var branch = inputArgs[0];
            var product = inputArgs[1];
            var price = decimal.Parse(inputArgs[2]);

            if (shops.ContainsKey(branch))
            {
                if (!shops[branch].ContainsKey(product))
                {
                    shops[branch][product] = price;
                }
            }
            else
            {
                shops.Add(branch, new Dictionary<string, decimal>());
                shops[branch].Add(product, price);
            }
        }
    }
}
