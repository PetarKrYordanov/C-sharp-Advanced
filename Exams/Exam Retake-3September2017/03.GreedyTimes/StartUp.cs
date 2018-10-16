using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _03.GreedyTimes
{
    class StartUp
    {
        public static long currentBagCapacity = 0;
        public static Dictionary<string, Dictionary<string, long>> bag = new Dictionary<string, Dictionary<string, long>>();
        public static long bagSize;
        static void Main(string[] args)
        {
            bagSize = long.Parse(Console.ReadLine());
       
            
            var input = Console.ReadLine();

            GetGoldFromInput(input);
            if (currentBagCapacity ==0)
            {
                return;
            }
            var GemPattern = @"\b(\S+gem)\s*([1-9][0-9]*\b)";
            GetItemsFromInput(input,currentBagCapacity,"Gem",GemPattern);
            if (currentBagCapacity == bag["Gold"]["Gold"])
            {
                PrintResult();
                return;
            }

            var cashPattern = @"\b([a-zA-Z]{3})\s*([1-9][0-9]*\b)";
            GetItemsFromInput(input, currentBagCapacity, "Cash", cashPattern);

            PrintResult();

        }

        private static void PrintResult()
        {
            var sb = new StringBuilder();
            foreach (var item in bag)
            {
               sb.AppendLine ($"<{item.Key}> ${item.Value.Values.Sum()}");
                foreach (var itemCount in item.Value.OrderByDescending(e=>e.Key).ThenBy(e=>e.Value))
                {
                    sb.AppendLine($"##{itemCount.Key} - {itemCount.Value}");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }


        private static void GetItemsFromInput(string input, long goldQuantity,string itemType,string pattern)
        {   
            Dictionary<string, long> itemInputCount = new Dictionary<string, long>();

            var ItemMatches = Regex.Matches(input, pattern,RegexOptions.IgnoreCase);

            if (!Regex.IsMatch(input,pattern))
            {
                return;
            }

            foreach (Match match in ItemMatches)
            {
                var gemName = match.Groups[1].Value;
                long itemQuantity =long.Parse(match.Groups[2].Value);

                if (!itemInputCount.ContainsKey(gemName))
                {
                    itemInputCount.Add(gemName, itemQuantity);
                }
                else
                {
                    itemInputCount[gemName] += itemQuantity;
                }
            }
            var currentItemQuantity = 0L;

            foreach (var item in itemInputCount.OrderByDescending(e=>e.Value))
            {
                var itemQuantity = item.Value;
                var itemName = item.Key;
                if (currentItemQuantity + itemQuantity<goldQuantity ==true
                    && currentItemQuantity+itemQuantity+currentBagCapacity<=bagSize)
                {

                    if (itemType == "Cash" )
                    {
                        var gemCount = bag.Where(e=>e.Key=="Gem").Sum(e=>e.Value.Select(f=>f.Value).Sum());
                        if (currentItemQuantity+itemQuantity>gemCount)
                        {
                            continue;
                        }
                    }
                    currentItemQuantity += itemQuantity;
                    PutItemInBag(itemName, itemQuantity,itemType);
                }
            }
            currentBagCapacity = bag.Values.Sum(e => e.Values.Sum());

        }

        private static void PutItemInBag(string ItemName, long ItemQuantity,string itemType)
        {
            if (bag.ContainsKey(itemType))
            {
                bag[itemType].Add(ItemName, ItemQuantity);
            }
            else
            {
                bag.Add(itemType, new Dictionary<string, long>());
                bag[itemType].Add(ItemName, ItemQuantity);
            }
        }

        private static void GetGoldFromInput(string input)
        {
            long currentGold = 0;
            var goldPattern = @"\bgold\s*([0-9][\d]*)";
            List<long> goldInputs = new List<long>();
            var goldMatches = Regex.Matches(input, goldPattern, RegexOptions.IgnoreCase);

            foreach (Match match in goldMatches)
            {
                goldInputs.Add(long.Parse(match.Groups[1].Value));
            }

            foreach (var gold in goldInputs.OrderByDescending(e=>e))
            {
                if (currentGold + gold<=bagSize)
                {
                    currentGold += gold;
                }
            }

            currentBagCapacity = currentGold;
            bag.Add("Gold", new Dictionary<string, long>());
            bag["Gold"].Add("Gold", currentGold);
        }
    }
}
