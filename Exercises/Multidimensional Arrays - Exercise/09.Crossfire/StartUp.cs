using System;
using System.Linq;
using System.Numerics;

namespace _09.Crossfire
{
    class StartUp
    {
        static int[][] matrix;
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            matrix = ReadAndFillMatrix(dimensions);

            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                var commandTokens = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                DestroyCells(commandTokens, dimensions);
                input = Console.ReadLine();
            }
            PrintResult();
        }

        private static void RemoveEmptyCells()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                // Remove destroyed cells if there is ones
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 0)
                    {
                        matrix[i] = matrix[i].Where(n => n > 0).ToArray();
                        break;
                    }
                }

                // Remove empty rows
                if (matrix[i].Count() < 1)
                {
                    matrix = matrix.Take(i).Concat(matrix.Skip(i + 1)).ToArray();
                    i--;
                }
            }
        }

        private static void PrintResult()
        {        
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i].Count() > 0)
                {
                    Console.WriteLine(string.Join(' ', matrix[i]));
                }
            }
        }

        private static void DestroyCells(int[] commandTokens, int[] dimensions)
        {
            var hitRow = commandTokens[0];
            var hitCol = commandTokens[1];
            var hitWave = commandTokens[2];

            // Mark destroyed part of the column
            for (int row = hitRow - hitWave; row <= hitRow + hitWave; row++)
            {
                if (IsInMatrix(row, hitCol, matrix))
                {
                    matrix[row][hitCol] = -1;
                }
            }

            // Mark destroyed part of the row
            for (int col = hitCol - hitWave; col <= hitCol + hitWave; col++)
            {
                if (IsInMatrix(hitRow, col, matrix))
                {
                    matrix[hitRow][col] = -1;
                }
            }
            RemoveEmptyCells();
        }

        private static bool IsInMatrix(int row, int col, int[][] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;
        }

        private static int[][] ReadAndFillMatrix(int[] dimensions)
        {
            var matrix = new int[dimensions[0]][];
            int count = 1;

            for (int i = 0; i < dimensions[0]; i++)
            {
                matrix[i] = new int[dimensions[1]];
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i][j] = count;
                    count++;
                }
            }
            return matrix;
        }
    }
}
