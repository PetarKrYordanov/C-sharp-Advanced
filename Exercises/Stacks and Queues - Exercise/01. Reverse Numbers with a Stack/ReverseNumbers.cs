namespace _01._Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stackNumbers = new Stack<int>(input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (stackNumbers.Count > 0)
            {
                Console.Write(stackNumbers.Pop() + " ");
            }
        }
    }
}
