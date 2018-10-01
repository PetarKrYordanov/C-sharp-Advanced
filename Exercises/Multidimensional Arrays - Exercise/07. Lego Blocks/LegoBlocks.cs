using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Lego_Blocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int jaggedArrayRows = int.Parse(Console.ReadLine());

            int[][] firstArr = ReadJaggedArray(jaggedArrayRows);
            int[][] secondArr = ReadJaggedArray(jaggedArrayRows);

            bool AreRowsEqual = true;
            int[] rowCount = new int[jaggedArrayRows];
            for (int r = 0; r < jaggedArrayRows; r++)
            {
                rowCount[r] = firstArr[r].Length + secondArr[r].Length;

                if (r > 0 && rowCount[r - 1] != rowCount[r])
                {
                    AreRowsEqual = false;
                    break;
                }
            }

            if (!AreRowsEqual)
            {
                Console.WriteLine($"The total number of cells is: {rowCount.Sum()}");
                Environment.Exit(0);
            }
            rowCount = null;

            secondArr = ReverseJaggedArr(secondArr);
            PrintResult(firstArr, secondArr, jaggedArrayRows);
        }

        private static void PrintResult(int[][] firstArr, int[][] secondArr, int jaggedArrayRows)
        {
            var result = new int[jaggedArrayRows][];

            for (int r = 0; r < jaggedArrayRows; r++)
            {
                result[r] = firstArr[r]?.Concat(secondArr[r])?.ToArray();
            }

            foreach (var row in result)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }
        }

        private static int[][] ReverseJaggedArr(int[][] secondArr)
        {


            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = secondArr[i].Reverse().ToArray();
            }

            return secondArr;
        }

        private static int[][] ReadJaggedArray(int jaggedArrayRows)
        {
            var arr = new int[jaggedArrayRows][];
            for (int r = 0; r < jaggedArrayRows; r++)
            {
                var input = Console.ReadLine()?
                    .Trim()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                arr[r] = input;
            }

            return arr;
        }
    }
}
