using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ParkingSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Trim()
                .Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var parking = new Parking(sizes);
            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                var commandArgs = command.Trim()
                    .Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                parking.ParkCar(commandArgs);
            }

         
        }
    }
    public class Parking
    {
        private bool[][] Matrix;

        public Parking(int[] dimensions)
        {
            var rows = dimensions[0];
            this.Matrix = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                this.Matrix[i] = new bool[dimensions[1]];
                this.Matrix[i][0] = true;
            }
        }

        public void ParkCar(int[] commandsArgs)
        {
            var startRow= commandsArgs[0];
            var desiredRow = commandsArgs[1];
            var desiredCol = commandsArgs[2];

            if (IsRowFull(desiredRow))
            {
                Console.WriteLine($"Row {desiredRow} full");
                return; 
            }

            if (!IsPlaceFree(desiredRow,desiredCol))
            {
                desiredCol = TakeFreePlace(desiredRow,desiredCol);
            }
            this.Matrix[desiredRow][desiredCol] = true;
          
            int distance = 1 + Math.Abs(desiredRow - startRow) + desiredCol;
            Console.WriteLine(distance);
        }

        private int TakeFreePlace(int desiredRow,int desiredCol)
        {
            int difference=int.MaxValue;
            int bestColumn = 0;
            for (int i =1; i < Matrix[desiredRow].Length; i++)
            {
                if (Matrix[desiredRow][i] == false)
                {
                    
                    if (Math.Abs(desiredCol-i)<difference)
                    {
                        bestColumn = i;
                        difference =Math.Abs( desiredCol-i);
                    }
                }
            }
            return bestColumn;
        }

        public bool IsPlaceFree(int row, int col)
        {
            if (this.Matrix[row][col] == false)
            {
                return true;
            }
            return false;
        }

        public bool IsRowFull(int row)
        {
            if (Matrix[row].Skip(1).All(x=>x==true))
            {
                return true;
            }
                return false;
            
        }
    }
}
