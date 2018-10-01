using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.StringMatrixRotation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputDegrees = Console.ReadLine().Trim()
                .Split("Rotate()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            var degrees = inputDegrees[0] % 360;

            var inputLines = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                inputLines.Add(input); 
            }

            if (degrees == 90)
            {
              var matrix=  Rotate90Degree(inputLines);
                Print(matrix);
            }
            else if (degrees == 180)
            {
                var matrix = Rotate180(inputLines);
            }
        }

        private static object Rotate180(List<string> inputLines)
        {
            var maxLength = inputLines.Max(e => e.Length);
            var matrix = new char[inputLines.Count, maxLength];

            for (int i = 0; i < inputLines.Count; i++)
            {
                inputLines[i] = inputLines[i].Reverse().ToString().PadRight(maxLength);
            }

            return matrix;
        }

        private static void Print(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }
        }

        private static char[,] Rotate90Degree(List<string> inputLines)
        {
            int maxLength = inputLines.Max(e => e.Length); 
            char[,] matrix = new char[maxLength, inputLines.Count];

            for (int i = 0; i < inputLines.Count; i++)
            {
                inputLines[i] = inputLines[i].PadRight(maxLength);
            }
            for (int col = inputLines.Count - 1; col >= 0; col--)
            {
                for (int row = 0; row < maxLength; row++)
                {
                    matrix[row, inputLines.Count - 1 - col] = inputLines[col][row];
                }
            }
            return matrix;
        }
    }
}
