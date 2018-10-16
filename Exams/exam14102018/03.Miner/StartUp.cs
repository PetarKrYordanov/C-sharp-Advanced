using System;
using System.Linq;
namespace _03.Miner
{
    class StartUp
    {
        public static char[][] matrix;
        public static int row;
        public static int col;
        public static int size;
        static void Main(string[] args)
        {
             size = int.Parse(Console.ReadLine());
            matrix = new char[size][];

            var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            FillMatrix(size);

            for (int i = 0; i < commands.Length; i++)
            {
                var currentCommand = commands[i];

                MovePlayer(currentCommand);

                if (matrix[row][col] =='e')
                {
                    Console.WriteLine($"Game over! ({row}, {col})");
                    Environment.Exit(0);
                }

                matrix[row][col] = 's';
                bool isCollected = AreCollected();

                if (isCollected)
                {
                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                    Environment.Exit(0);
                }
            }
            int coalCount = GetCoals();
            Console.WriteLine($"{coalCount} coals left. ({row}, {col})");
        }

        private static int GetCoals()
        {
            var count = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int k = 0; k < matrix[i].Length; k++)
                {
                    if (matrix[i][k] =='c')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static bool AreCollected()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Contains('c'))
                {
                    return false; 
                }
            }
            return true;
        }

        private static void MovePlayer(string currentCommand)
        {
            matrix[row][col] = '*';
            switch (currentCommand)
            {
                case "left":
                    col--;
                    if (col < 0)
                    {
                        col = 0;
                    }
                   
                    break;
                case "right":
                    col++;
                    if (col > size - 1)
                    {
                        col = size - 1;
                    }
                    break;
                case "up":
                    row--;
                    if (row < 0)
                    {
                        row = 0;
                    }
                    break;
                case "down":
                    row++;
                    if (row > size - 1)
                    {
                        row = size - 1;
                    }
                    break;
                default:
                    break;
            }

        }

        private static void FillMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine();
                matrix[i] = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(e=>char.Parse(e)).ToArray();
                if (input.Contains('s'))
                {
                    row = i;
                    col = Array.IndexOf(matrix[i],'s');
                }

            }
        }
    }
}
