namespace _04.EvenTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var numbers = GetNumbers(numbersCount);

            Console.WriteLine(string.Join(' ', numbers));
        }

        private static int[] GetNumbers(int n)
        {
            var numbersCount = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;
                }
                else
                {
                    numbersCount.Add(number, 1);
                }
            }
            var numbers = numbersCount.Where(e => e.Value % 2 == 0).Select(e=>e.Key).ToArray();
            return numbers;           
        }
    }
}
