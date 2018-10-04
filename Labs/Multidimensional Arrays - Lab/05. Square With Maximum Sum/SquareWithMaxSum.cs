using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    class SquareWithMaxSum
    {
        static void Main(string[] args)
        {
            int[] rowsAndColums = Console.ReadLine()
                 .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColums[0], rowsAndColums[1]];

            for (int rows = 0; rows < rowsAndColums[0]; rows++)
            {
                var rowValues = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int colums = 0; colums < rowsAndColums[1]; colums++)
                {
                    matrix[rows, colums] = rowValues[colums];
                }
            }
          
            Matrix bestMatrix = new Matrix();
            bestMatrix.Sum = int.MinValue;

            for (int rows = 0; rows < matrix.GetLength(0)-1; rows++)
            {
                for (int colums = 0; colums < matrix.GetLength(1)-1; colums++)
                {
                    int currentSum = getCurrentSum(rows, colums,matrix);

                    if (currentSum>bestMatrix.Sum)
                    {
                        bestMatrix.Sum = currentSum;
                        bestMatrix.StartColum = colums;
                        bestMatrix.StartRow = rows;
                    }
                }
            }
            PrintResult(matrix, bestMatrix);                 
        }

        private static void PrintResult(int[,] matrix, Matrix bestMatrix)
        {
            for (int row = bestMatrix.StartRow; row <= bestMatrix.StartRow+1; row++)
            {
                for (int colum = bestMatrix.StartColum; colum <= bestMatrix.StartColum+1; colum++)
                {
                    Console.Write(matrix[row,colum]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(bestMatrix.Sum);
        }

        private static int getCurrentSum(int rows, int colums, int[,] matrix)
        {
            int currentSum = matrix[rows, colums] 
                           + matrix[rows, colums + 1] 
                           + matrix[rows + 1, colums]
                           + matrix[rows + 1, colums + 1];

            return currentSum;
        }

        
    }
    public class Matrix
    {
        public int StartColum { get; set; }
        public int StartRow { get; set; }
        public int Sum { get; set; }
    }
}
