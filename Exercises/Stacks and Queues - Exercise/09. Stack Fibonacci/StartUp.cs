using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Stack_Fibonacci
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nthNumber = int.Parse(Console.ReadLine());
            var fibNumber = new List<long>();
            fibNumber.Add(0);
            fibNumber.Add(1);

            var numbers = new Stack<long>();
            numbers.Push(0);
            numbers.Push(1);
            while (fibNumber.Count!=nthNumber+1)
            {
                var lastNumber = numbers.Pop();
                var beforeLastNumber = numbers.Peek();
                var sum = lastNumber + beforeLastNumber;

                fibNumber.Add(sum);

                numbers = new Stack<long>(fibNumber);
            }
            Console.WriteLine(fibNumber.Last());
        }
    }
}
