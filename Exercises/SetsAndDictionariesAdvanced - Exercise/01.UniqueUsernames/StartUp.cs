namespace _01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            var collection = new HashSet<string>();
            int linesNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesNumber; i++)
            {
                collection.Add(Console.ReadLine());
            }

            foreach (var line in collection)
            {
                Console.WriteLine(line);
            }
        }
    }
}
