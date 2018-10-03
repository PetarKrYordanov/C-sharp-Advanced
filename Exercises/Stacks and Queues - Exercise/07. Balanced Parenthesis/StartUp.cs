using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parenthesis
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var parenthesesLine = Console.ReadLine();

            var openedParentheses = new Stack<char>();
            var isMatched = false;

            var openingCases = new char[] { '{', '[', '(' };

            for (int i = 0; i < parenthesesLine.Length; i++)
            {
                if (openingCases.Contains(parenthesesLine[i]))
                {
                    openedParentheses.Push(parenthesesLine[i]);
                }
                else
                {
                    if (openedParentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (parenthesesLine[i])
                    {
                        case ')':
                            if (openedParentheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (openedParentheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openedParentheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
