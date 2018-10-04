namespace _02.SetsOfElements
{
using System;
using System.Collections.Generic;
using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstArr = GetNumbers(input[0]);
            var secondArr = GetNumbers(input[1]);
            var result = new List<int>();

            foreach (var item in firstArr)
            {
                if (secondArr.Any(e=>e == item))
                {
                    result.Add(item);
                }
            }

            Console.WriteLine(string.Join(' ',result));        
        }

        private static int[] GetNumbers(int n)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                set.Add(number);
            }
           
            return set.ToArray();
        }
    }
}
