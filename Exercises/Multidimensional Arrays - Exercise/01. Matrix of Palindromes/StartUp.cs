using System;
using System.Linq;

namespace _01._Matrix_of_Palindromes
{
    class StartUp
    {
        static char[] alphabet = "abcdefghijklmnopqrstuvwxyz"
            .ToCharArray();
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rows = dimensions[0];
            var colums = dimensions[1];

            var matrix = new string[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    char[] currentCell = new char[3] ;
                    currentCell[0] = alphabet[i];
                    currentCell[2] = alphabet[i];
                    currentCell[1] = alphabet[i+j];

                    Console.Write(new string(currentCell)+ " ");                   
                }
                Console.WriteLine();
            }
        }
    }
}
