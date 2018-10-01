using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._Reverse_Strings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            Stack<string> stackInput = new Stack<string>();

            for (int i = 0; i < input.Count; i++)
            {
                stackInput.Push(input[i]);
            }
            var result = new List<string>();

            while (stackInput.Count >0)
            {
                var curentWord = stackInput.Pop().ToCharArray();
                Array.Reverse(curentWord);                             
               result.Add(new string(curentWord));
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
