using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.CupsandBottles
{
    class Program
    {
        public static int wastedWater;
        static void Main(string[] args)
        {
            var cupsCapacity = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var bottlesQty = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            wastedWater = 0;

            Queue<int> cups = GetCups(cupsCapacity);
            Stack<int> botles = GetBotles(bottlesQty);
            
            while (cups.Count >= 1)
            {
                if (botles.Count == 0)
                {
                    break;
                }
                var currentCup = cups.Dequeue();
                var currentBotle = botles.Pop();
                if (currentBotle >= currentCup)
                {
                    wastedWater += currentBotle - currentCup;
                }
                else
                {
                    bool bot = false; 
                    currentCup -= currentBotle;

                    while (botles.Count >= 1 && currentCup > 0)
                    {
                        currentBotle = botles.Pop();
                        if (currentBotle >= currentCup)
                        {
                            wastedWater += (currentBotle - currentCup);
                            currentCup = 0;
                            break;
                        }
                        else
                        {
                            currentCup -= currentBotle;
                        }
                        
                       
                    }
                    
                }
            }

            if (botles.Count != 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', botles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");

        }

        private static Stack<int> GetBotles(int[] bottlesQty)
        {
            var bottles = new Stack<int>();
            for (int i = 0; i < bottlesQty.Length; i++)
            {
                bottles.Push(bottlesQty[i]);
            }
            return bottles;
        }

        private static Queue<int> GetCups(int[] cupsCapacity)
        {
            var cup = new Queue<int>();
            for (int i = 0; i < cupsCapacity.Length; i++)
            {
                cup.Enqueue(cupsCapacity[i]);
            }
            return cup;
        }
    }
}
