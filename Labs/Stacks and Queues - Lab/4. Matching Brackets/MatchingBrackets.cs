using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '(' && input[i] != ')')
                {
                    continue;
                }

                if (input[i] == '(')
                {
                    stack.Push(i);
                }
              
                if (input[i]== ')')
                {
                    int startIndex = stack.Pop();
                    var endIndex = i;
                    var output = input.Substring(startIndex, i-startIndex+1);

                    Console.WriteLine(output);
                }

            }
        }
    }
}
