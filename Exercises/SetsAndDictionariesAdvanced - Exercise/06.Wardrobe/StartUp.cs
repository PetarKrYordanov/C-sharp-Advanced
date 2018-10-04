using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class StartUp
    {
        public static Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
        static void Main(string[] args)
        {
            int lineNumber = int.Parse(Console.ReadLine());

            GetItems(lineNumber);

            PrintResult();
        }

        private static void PrintResult()
        {
            var searchedItemArgs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var searchedColor = searchedItemArgs[0];
            var searchedItem = searchedItemArgs[1];

            foreach (var colorItems in wardrobe)
            {
                Console.WriteLine($"{colorItems.Key} clothes:");

                foreach (var dresCount in colorItems.Value)
                {
                    Console.Write($"* {dresCount.Key} - {dresCount.Value}");
                    if (searchedColor == colorItems.Key && searchedItem ==dresCount.Key)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void GetItems(int lineNumber)
        {
            for (int i = 0; i < lineNumber; i++)
            {
                var inputArgs = Console.ReadLine().Split(" -> ");
                var color = inputArgs[0];
                var items = inputArgs[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (wardrobe.ContainsKey(color))
                {
                    FillNestedDictionary(items, color);
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    FillNestedDictionary(items,color);
                }

            }
        }

        private static void FillNestedDictionary(string[] items, string color)
        {
            for (int itemIndex = 0; itemIndex < items.Length; itemIndex++)
            {
                var currentItem = items[itemIndex];
                if (wardrobe[color].ContainsKey(currentItem))
                {
                    wardrobe[color][currentItem]++;
                }
                else
                {                 
                    wardrobe[color].Add(currentItem, 1);
                }
            }
        }
    }
}
