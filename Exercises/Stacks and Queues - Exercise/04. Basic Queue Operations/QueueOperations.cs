namespace _04._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class QueueOperations
    {
        static void Main(string[] args)
        {
            int[] inputline = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersInQueue = inputline[0];
            int timesToPop = inputline[1];
            int searchNumber = inputline[2];

            Queue<int> queue = new Queue<int>();        
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersInQueue; i++)
            {
                queue.Enqueue(secondLine[i]);
            }

            for (int i = 0; i < timesToPop; i++)
            {
                int currentNumber = queue.Dequeue();
            }

            if (queue.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(queue.Min());

                }
            }
        }
    }
}
