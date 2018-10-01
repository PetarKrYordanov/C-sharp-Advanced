using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Simple_Calculator
{
    class SimpleCalc
    {
        static void Main(string[] args)
        {
            List<string> inputAsList = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            Stack<string> inputStack = new Stack<string>();

            for (int i = inputAsList.Count - 1; i >= 0; i--)
            {
                inputStack.Push(inputAsList[i]);
            }

            int sum = 0;
            int num=0;
            string sign = "+";
          int  count = 0;
            while (inputStack.Count>0)
            {
                if (count%2==0)
                {
                    num = int.Parse(inputStack.Pop());
                }
                else
                {
                    sign = inputStack.Pop();
                    count++; continue;
                }
                if (sign =="+")
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
                count++;
            }

            Console.WriteLine(sum);
        }
    }
}
