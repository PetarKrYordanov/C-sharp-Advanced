using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Hot_Potato
{
    class HotPatato
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            var listOfItems = Console.ReadLine().Split(' ').ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < listOfItems.Count; i++)
            {
                queue.Enqueue(listOfItems[i]);
            }

            while (queue.Count != 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        var itemRemoved = queue.Dequeue();
                        Console.WriteLine($"Removed {itemRemoved}");
                    }
                    else
                    {
                        var ToAdd = queue.Dequeue();
                        queue.Enqueue(ToAdd);
                    }
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
