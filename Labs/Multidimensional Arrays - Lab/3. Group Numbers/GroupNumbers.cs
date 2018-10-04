using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Group_Numbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var sizes = new int[3];
            foreach (var num in inputNumbers)
            {
                sizes[Math.Abs(num % 3)]++;
            }
            var jaggedArray = new int[3][];

            for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArray[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];
            foreach (var num in inputNumbers)
            {
                var remainder = Math.Abs(num % 3);
                jaggedArray[remainder][index[remainder]] = num;
                index[remainder]++;
            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",array));
            }
        }
    }
}
