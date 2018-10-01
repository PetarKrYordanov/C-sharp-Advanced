using System;
using System.Linq;

namespace _02._Diagonal_Difference
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new long[matrixSize, matrixSize];
            FillMatrix(matrix, matrixSize);

            long mainDiagonalSum = SumMainDiagonal(matrix, matrixSize);
            long secondDiagonalSum = SumSecondDiagonal(matrix, matrixSize);

            var result = Math.Abs(mainDiagonalSum - secondDiagonalSum);
            Console.WriteLine(result);
        }

        private static long SumMainDiagonal(long[,] matrix,int matrixSize)
        {
            long sum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (i==j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }

        private static long SumSecondDiagonal(long[,] matrix, int matrixSize)
        {
            long sum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                
                sum += matrix[0 + i, matrixSize - 1 - i];
            }
            return sum;
        }

        private static void FillMatrix(long[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                var rowsInput = Console.ReadLine()
                    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                for (int column = 0; column < matrixSize; column++)
                {
                    matrix[row, column] = rowsInput[column];
                }
            }
        }
    }
}
