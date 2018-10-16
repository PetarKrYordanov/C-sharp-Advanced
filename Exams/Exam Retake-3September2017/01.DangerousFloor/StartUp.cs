using System;
using System.Linq;

namespace _01.DangerousFloor
{
    class StartUp
    {
        public static char[][] board = new char[8][];
        public static int boardSize = 8;
        public static int currentRow;
        public static int currentCol;

        public static int desiredRow;
        public static int desiredCol;
        static void Main(string[] args)
        {
            SetPiecesOnTheBoard();
            GetCommands();
        }

        private static void GetCommands()
        {
            while (true)
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "END")
                {
                    break;
                }

                var piece = inputCommand[0];
                var posiotionsAsString = inputCommand.Substring(1).Split('-');

                bool isPieceExist = CheckForPiece(piece, posiotionsAsString);
                if (!isPieceExist)
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }

                bool isValidMove;
                switch (piece)
                {
                    case 'R':
                        isValidMove = IsRockValidMove();
                        break;
                    case 'P':
                        isValidMove = IsPawnValidMove();
                        break;
                    case 'B':
                        isValidMove = IsBishopValidMove();
                        break;
                    case 'K':
                        isValidMove = IsKingValidMove();
                        break;
                    case 'Q': isValidMove = IsQuenValidMove();
                        break;
                    default:
                        isValidMove = false;
                        break;
                }

                if (!isValidMove)
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                bool isInArray = (desiredRow >= 0 && desiredRow <= 7) && (currentCol >= 0 && desiredCol <= 7);
                if (!isInArray)
                {
                    Console.WriteLine("Move go out of board!");
                    continue;
                }
                else
                {
                    board[currentRow][currentCol] = 'x';
                    board[desiredRow][desiredCol] = piece;
                }

            }
        }


        private static bool IsQuenValidMove()
        {
            if (IsRockValidMove() || IsBishopValidMove())
            {
                return true;
            }
            return false;   
        }

        private static bool IsKingValidMove()
        {
            if (Math.Abs(currentCol - desiredCol) <= 1 && Math.Abs(currentRow - desiredRow) <= 1 && (Math.Abs(currentCol - desiredCol) != 0 || Math.Abs(currentRow - desiredRow) != 0))
            {
                return true;
            }
            return false;
        }

        private static bool IsBishopValidMove()
        {
            if (Math.Abs(currentCol - desiredCol) == Math.Abs(currentRow - desiredRow) && Math.Abs(currentRow - desiredRow) != 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPawnValidMove()
        {
            if (currentCol == desiredCol && (currentRow - 1 == desiredRow))
            {
                return true;
            }
            return false;
        }

        private static bool IsRockValidMove()
        {
            if ((currentCol == desiredCol) || (currentRow == desiredRow))
            {
                return true;
            }
            return false;
        }

        private static bool CheckForPiece(char piece, string[] posiotionsAsString)
        {
            //if (posiotionsAsString.Length != 2)
            //{
            //    return false;
            //}

            currentRow = int.Parse(posiotionsAsString[0][0].ToString());
            currentCol = int.Parse(posiotionsAsString[0][1].ToString());

            desiredRow = int.Parse(posiotionsAsString[1][0].ToString());
            desiredCol = int.Parse(posiotionsAsString[1][1].ToString());

            if (currentRow < 0 || currentRow > 7 )
            {
                return false;
            }
            if (board[currentRow][currentCol] == piece)
            {
                return true;
            }
            return false;
        }

        private static void SetPiecesOnTheBoard()
        {
            for (int i = 0; i < boardSize; i++)
            {
                var inputArgs = Console.ReadLine()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                board[i] = new char[8];
                board[i] = inputArgs;

            }
        }
    }
}
