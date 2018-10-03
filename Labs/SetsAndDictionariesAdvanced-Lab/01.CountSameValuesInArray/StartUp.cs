namespace _01.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var doubleOccurrences = new Dictionary<double, int>();

            var inputArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < inputArgs.Length; i++)
            {
                var currentNumber = inputArgs[i];
                if (!doubleOccurrences.ContainsKey(currentNumber))
                {
                    doubleOccurrences.Add(currentNumber, 1);
                }
                else
                {
                    doubleOccurrences[currentNumber]++;
                }
            }

            foreach (var item in doubleOccurrences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");

            }
        }
    }
}