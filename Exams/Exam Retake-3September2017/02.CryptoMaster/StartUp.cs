using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CryptoMaster
{
    class StartUp
    {
        public static Queue<int> queue = new Queue<int>();
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxSequenceCount = numbers.Distinct().Count();
            var maxSequence = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                for (int step = 1; step < numbers.Length; step++)
                {
                    var currentIndex = index;
                    var nextIndex = (currentIndex + step) % numbers.Length;
                    var thisSequence = 1;

                    while (numbers[nextIndex] > numbers[currentIndex])
                    {
                        currentIndex = nextIndex;
                        nextIndex = (currentIndex + step) % numbers.Length;

                        thisSequence++;
                    }

                    if (thisSequence > maxSequence)
                    {
                        maxSequence = thisSequence;
                        if (maxSequence == maxSequenceCount)
                        {
                            Console.WriteLine(maxSequence);
                            Environment.Exit(0);
                        }
                    }
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
