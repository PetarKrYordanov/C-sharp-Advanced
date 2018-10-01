using System;
using System.Linq;
using System.Text;

namespace _06._Target_Practice
{
    class Program
    {
        static int rows;
        static int columns;
        static char[,] matrix;
        static void Main(string[] args)
        {
            FillMatrix();

            ShotMatrix();

           GravityMatrix();

            PrintMatrix();
        }

        private static void GravityMatrix()
        {
            var currentColumn = columns - 1;

            while (currentColumn>=0)
            {

                var tempColumn = GetColumnFromMatrix(currentColumn);
                int rowIndex = rows - tempColumn.Length;
                for (int row =0; row < rows; row++)
                {
                    if (row <rowIndex)
                    {
                        matrix[row, currentColumn] = ' ';
                    }
                    else
                    {
                        matrix[row, currentColumn] = tempColumn[row-rowIndex];
                    }
                }
                currentColumn--;
            }
        }

        private static char[] GetColumnFromMatrix(int currentColumn)
        {
            var currentColumnArray = new char[rows];

            for (int index = 0; index < rows; index++)
            {
                currentColumnArray[index] = matrix[index, currentColumn];
            }

            char[] tempArray = currentColumnArray.Select(x => x).Where(x=>x!=' ').ToArray();
            return tempArray;
        }

        private static void ShotMatrix()
        {
            var shotParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotRow = shotParameters[0];
            int shotColumn = shotParameters[1];
            int shotRadius = shotParameters[2];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (Math.Pow(row-shotRow,2) + Math.Pow(column-shotColumn,2)<=shotRadius*shotRadius)
                    {
                        matrix[row, column] = ' ';
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            var stringBuilder = new StringBuilder();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    stringBuilder.Append(matrix[row, col]);
                }
                stringBuilder.AppendLine();
            }
            var result = stringBuilder.ToString();
            Console.Write(result);
        }

        private static void FillMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            rows = dimensions[0];
            columns = dimensions[1];

            int rowCount = 0;
            int countCells = 0;
            var snake = Console.ReadLine().Trim();
            matrix = new char[rows, columns];

            for (int row = rows - 1; row >= 0; row--)
            {
                if (rowCount%2==0)
                {
                    for (int col = columns - 1; col >= 0; col--)
                    {
                        var charIndex = countCells % snake.Length;

                        matrix[row,col]=snake[charIndex];
                        countCells++;
                    }
                }
                else
                {
                    for (int col = 0; col < columns; col++)
                    {
                        var charIndex = countCells % snake.Length;

                        matrix[row, col] = snake[charIndex];
                        countCells++;
                    }
                }
                rowCount++;
            }
        }
    }
}
