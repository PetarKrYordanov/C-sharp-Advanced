using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var charCount = new Dictionary<char, int>();

            charCount = PrintSymbolsCount();
            PrintResult(charCount);
        }

        private static void PrintResult(Dictionary<char, int> charCount)
        {
            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }

        private static Dictionary<char, int> PrintSymbolsCount()
        {
            var input = Console.ReadLine();
            var charCount = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];
                if (charCount.ContainsKey(letter))
                {
                    charCount[letter]++;
                }
                else
                {
                    charCount.Add(letter, 1);
                }
            }

            charCount = charCount.OrderBy(e => e.Key).ToDictionary(x => x.Key, x => x.Value);
            return charCount;
        }
    }
}
