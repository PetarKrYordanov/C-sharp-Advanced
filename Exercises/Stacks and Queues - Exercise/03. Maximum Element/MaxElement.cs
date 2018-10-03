namespace _03._Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaxElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> myStack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxElement = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] comandArgs = Console.ReadLine().Split();
                string comand = comandArgs[0];
                if (comand == "1")
                {
                    int numberToPush = int.Parse(comandArgs[1]);
                    myStack.Push(numberToPush);

                    if (numberToPush > maxElement)
                    {
                        maxElement = numberToPush;
                        maxNumbers.Push(numberToPush);
                    }
                }
                else if (comand == "2")
                {
                    int ElementAtTop = myStack.Pop();
                    int currentMaxNumber = maxNumbers.Peek();

                    if (ElementAtTop == currentMaxNumber)
                    {
                        maxNumbers.Pop();

                        if (maxNumbers.Count > 0)
                        {
                            maxElement = maxNumbers.Peek();
                        }
                    }

                }
                else
                {
                    Console.WriteLine(maxNumbers.Max());
                }
            }
        }
    }
}
