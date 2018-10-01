using System;
using System.Collections.Generic;

namespace _3._Decimal_to_Binary_Converter
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            var inputNum = int.Parse(Console.ReadLine());

            var result = new Stack<int>();
           
            while (inputNum>0)
            {
                if (inputNum == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
                if (inputNum % 2 ==0)
                {
                    result.Push(0);
                }
                else
                {
                    result.Push(1);
                }
                inputNum /= 2;
            }

            while (result.Count>0)
            {
                Console.Write(result.Pop());
            }
            Console.WriteLine();
        }
    }
}
