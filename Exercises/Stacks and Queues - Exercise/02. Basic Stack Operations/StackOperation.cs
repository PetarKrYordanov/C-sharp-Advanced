namespace _02._Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StackOperation
    {
        static void Main()
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersInStack = firstLine[0];
            int timesToPop = firstLine[1];
            int searchNumber = firstLine[2];

            Stack<int> stack = new Stack<int>();
            int smalestNumber = int.MaxValue;
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersInStack; i++)
            {
                stack.Push(secondLine[i]);
            }

            for (int i = 0; i < timesToPop; i++)
            {
                int currentNumber = stack.Pop();
            }

            if (stack.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Min());

                }
            }
        }
    }
}
