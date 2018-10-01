using System;
using System.Linq;

namespace _04.Maximal_Sum
{
    public class StartUp
    {

        static int[,] matrix;
        public static int[,] bestMatrix = new int[3, 3];
        static int bestSum;
        static void Main(string[] args)
        {
            FillMatrix();
            bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    CalculateBestSumMatrix(row, column);
                }
            }
            Console.WriteLine("Sum = " + bestSum);
            PrintBestMatrix();
        }

        private static void PrintBestMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(bestMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void CalculateBestSumMatrix(int row, int col)
        {
            int currentSum = 0;

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    currentSum += matrix[i, j];
                }
            }
            if (currentSum > bestSum)
            {
                bestSum = currentSum;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        bestMatrix[i, j] = matrix[row + i, col + j];
                    }
                }
            }
            currentSum = 0;

        }

        private static void FillMatrix()
        {
            var dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];
            matrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                var rowInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = rowInput[column];
                }
            }
        }
    }
}
