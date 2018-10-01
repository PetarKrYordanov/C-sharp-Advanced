using System;
using System.Linq;

namespace _03._Squares_in_Matrix
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var rows = dimensions[0];
            var columns = dimensions[1];
            var matrix = new char[rows, columns];

            FillMatrix(matrix, rows, columns);

            var count = CountMatrix(matrix, rows, columns);
            Console.WriteLine(count);
        }

        private static object CountMatrix(char[,] matrix, int rows, int columns)
        {
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < columns - 1; col++)
                {
                    char c = matrix[row, col];
                    if (matrix[row, col + 1] == c 
                        && matrix[row + 1, col] == c 
                        && matrix[row + 1, col + 1] == c)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static void FillMatrix(char[,] matrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                var rowInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x[0]).ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = rowInput[column];
                }
            }
        }
    }
}
