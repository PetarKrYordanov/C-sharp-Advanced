using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            var matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                var rowInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = rowInput[j];
                }
            }
        }
    }
}
