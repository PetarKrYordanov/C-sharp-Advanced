namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            var linesCount = int.Parse(Console.ReadLine());

            var result = FillSet(linesCount);

            result = result.OrderBy(e => e).ToHashSet();

            Console.WriteLine(string.Join(' ',result));
        }

        private static HashSet<string> FillSet(int linesCount)
        {
            var set = new HashSet<string>();

            for (int i = 0; i < linesCount; i++)
            {
                var inputArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var item in inputArgs)
                {
                    set.Add(item);
                }
            }

            return set;
        }
    }
}
