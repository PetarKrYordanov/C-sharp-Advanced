using System;
using System.Linq;

namespace _08._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static char[,] board;
        static int playerRow;
        static int playerCol;
        static bool isDeath = false;
        static bool isPlayerOut = false;
        static int[] lastCordinates = new int[2] { playerRow, playerCol };
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            board = ReadFillMatrix(dimensions);
            char[] movements = Console.ReadLine()?.Trim().ToCharArray();

            foreach (var move in movements)
            {
                MovePlayer(move);
                MultiplyBunies();

                if (isPlayerOut)
                {
                    PrintResult("won");
                    break;
                }

                if (isDeath)
                {
                    PrintResult("dead");
                    break;
                }
            }

            if (isDeath == false && isPlayerOut == false)
            {
                while (!isDeath)
                {
                    MultiplyBunies();
                }
                PrintResult("dead");
            }
        }

        private static void PrintResult(string result)
        {
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    Console.Write(board[r, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{result}: {lastCordinates[0]} {lastCordinates[1]}");
        }

        private static void MultiplyBunies()
        {
            bool isValid = true;
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    var currentBunny = board[r, c];
                    if (currentBunny == 'B')
                    {
                        // multiply bunnies Up
                        if (r - 1 >= 0 && board[r - 1, c] == '.')
                        {
                            board[r - 1, c] = 'N';
                        }
                        else if (r - 1 >= 0 && board[r - 1, c] == 'P' && isDeath ==false)
                        {
                            isDeath = true;
                            board[r - 1, c] = 'N';
                            lastCordinates = new int[] {playerRow,playerCol};
                        }

                        //Multiply bunnies Down
                        if (r + 1 < board.GetLength(0) && board[r + 1, c] == '.')
                        {
                            board[r + 1, c] = 'N';
                        }
                        else if (r + 1 < board.GetLength(0) && board[r + 1, c] == 'P' && isDeath== false)
                        {
                            isDeath = true;
                            board[r + 1, c] = 'N';
                            lastCordinates = new int[] { playerRow,playerCol};
                        }

                        //Multiply bunnies Left
                        if (c - 1 >= 0 && board[r, c - 1] == '.')
                        {
                            board[r, c - 1] = 'N';
                        }
                        else if (c - 1 >= 0 && board[r, c - 1] == 'P' && isDeath == false)
                        {
                            isDeath = true;
                            board[r, c - 1] = 'N';
                            lastCordinates = new int[] { playerRow, playerCol };
                        }

                        //Multiply bunnies Right
                        if (c + 1 < board.GetLength(1) && board[r, c + 1] == '.')
                        {
                            board[r, c + 1] = 'N';
                        }
                        else if (c + 1 < board.GetLength(1) && board[r, c + 1] == 'P' && isDeath == false)
                        {
                            isDeath = true;
                            board[r, c + 1] = 'N';
                            lastCordinates = new int[] { playerRow, playerCol};
                        }

                        if (isDeath == true && isValid)
                        {
                            isValid = false;
                        }
                    }
                }
            }
            // set new bunnies as B
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if (board[r, c] == 'N')
                    {
                        board[r, c] = 'B';
                    }
                }
            }
        }

        private static void MovePlayer(char move)
        {
            int[] preveiousPostion = new int[2] { playerRow, playerCol };
            board[playerRow, playerCol] = '.';
            switch (move)
            {
                case 'U':
                    playerRow--;
                    break;
                case 'D':
                    playerRow++;
                    break;
                case 'L':
                    playerCol--;
                    break;
                case 'R':
                    playerCol++;
                    break;
                default:
                    break;
            }
            if (playerRow < 0 || playerRow >= board.GetLength(0))
            {
                isPlayerOut = true;
            }

            if (playerCol < 0 || playerCol >= board.GetLength(1))
            {
                isPlayerOut = true;
            }

            if (isPlayerOut)
            {
                lastCordinates = preveiousPostion;
                return;
            }

            if (board[playerRow, playerCol] == 'B')
            {
                isDeath = true;
                lastCordinates[0] = playerRow;
                lastCordinates[1] = playerCol;
            }
            else
                board[playerRow, playerCol] = 'P';

        }

        private static char[,] ReadFillMatrix(int[] dimensions)
        {
            int rows = dimensions[0];
            int colums = dimensions[1];

            char[,] matrix = new char[rows, colums];

            for (int row = 0; row < rows; row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();
                for (int col = 0; col < colums; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (rowInput[col] == 'P')
                    {
                        playerCol = col;
                        playerRow = row;
                    }
                }
            }
            return matrix;
        }
    }
}
