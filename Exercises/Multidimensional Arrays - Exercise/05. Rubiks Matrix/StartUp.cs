using System;
using System.Linq;

namespace _05._Rubiks_Matrix
{
  public  class StartUp
    {
        private static int rows;
        private static int columns;
        private static int[,] matrix;
        private static int comandNumbers;
        static void Main(string[] args)
        {
            FillMatrix();

            comandNumbers = int.Parse(Console.ReadLine());
            for (int comand = 0; comand < comandNumbers; comand++)
            {
                var currentComand = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

                ManupulateComand(currentComand);
            }
            RearrangeMatrix();
            Console.WriteLine();
        }

        private static void RearrangeMatrix()
        {
            var searchedNumber = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (matrix[row, col] == searchedNumber)
                    {
                        Console.WriteLine("No swap required");
                        searchedNumber++;
                        continue;
                    }
                    else
                    {
                        bool isFound = false;
                        for (int r = row; r < rows; r++)
                        {
                            for (int c = 0; c < columns; c++)
                            {
                                if (matrix[r,c]==searchedNumber)
                                {
                                var tempNumber = matrix[row, col];
                                    matrix[row, col] = searchedNumber;
                                    matrix[r, c] = tempNumber;

                                    Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                    isFound = true;
                                    break;
                                }
                            }
                            if (isFound)
                            {
                                break;
                            }
                        }
                    }

                    searchedNumber++;
                }
            }

        }

        private static void ManupulateComand(string[] currentComand)
        {
            var index = int.Parse(currentComand[0]);
            var shiftRotations = int.Parse(currentComand[2]);
            var comand = currentComand[1];

            switch (comand)
            {
                case "down":
                    MakeUpOrDownComand(index, shiftRotations % rows);
                    break;
                case "up":
                    int direction = -1;
                    MakeUpOrDownComand(index, shiftRotations % rows, direction);
                    break;
                case "right":
                    MakeLeftOrRightComand(index, shiftRotations % columns);
                    break;
                case "left":
                    direction = -1;
                    MakeLeftOrRightComand(index, shiftRotations % columns, direction);
                    break;
                default:
                    break;
            }

        }

        private static void MakeLeftOrRightComand(int index, int rotations, int direction = 1)
        {
            if (rotations == 0)
            {
                return;
            }
            var tempRowArray = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                tempRowArray[i] = matrix[index, i];
            }
            if (direction > 0)
            {
                var firstPart = tempRowArray.Skip(columns - rotations).Take(rotations).ToArray();
                var secondPart = tempRowArray.Take(columns - rotations).ToArray();
                MakeChangesToRowInMatrix(index, firstPart, secondPart);
            }
            else
            {
                var firstPart = tempRowArray.Skip(rotations).Take(columns - rotations).ToArray();
                var secondPart = tempRowArray.Take(rotations).ToArray();
                MakeChangesToRowInMatrix(index, firstPart, secondPart);
            }
        }

        private static void MakeChangesToRowInMatrix(int index, int[] firstPart, int[] secondPart)
        {
            for (int i = 0; i < columns; i++)
            {
                if (i < firstPart.Length)
                {
                    matrix[index, i] = firstPart[i];
                }
                else
                {
                    matrix[index, i] = secondPart[i - firstPart.Length];
                }
            }
        }

        private static void MakeUpOrDownComand(int index, int rotations, int direction = 1)
        {
            if (rotations == 0)
            {
                return;
            }
            var tempColumnArray = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                tempColumnArray[i] = matrix[i, index];
            }
            if (direction > 0)
            {
                var firstPart = tempColumnArray.Skip(rows - rotations).Take(rotations).ToArray();
                var secondPart = tempColumnArray.Take(rows - rotations).ToArray();
                MakeChangesToColumnInMatrix(index, firstPart, secondPart);
            }
            else
            {
                var firstPart = tempColumnArray.Skip(rotations).Take(rows - rotations).ToArray();
                var secondPart = tempColumnArray.Take(rotations).ToArray();
                MakeChangesToColumnInMatrix(index, firstPart, secondPart);
            }
        }

        private static void MakeChangesToColumnInMatrix(int index, int[] firstPart, int[] secondPart)
        {
            for (int i = 0; i < rows; i++)
            {
                if (i < firstPart.Length)
                {
                    matrix[i, index] = firstPart[i];
                }
                else
                {
                    matrix[i, index] = secondPart[i - firstPart.Length];
                }
            }
        }

        private static void FillMatrix()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            rows = dimensions[0];
            columns = dimensions[1];
            matrix = new int[rows, columns];
            int count = 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }

        }
    }
}
