using System;
using System.Collections;
using System.Collections.Generic;

namespace _05._Sequence_With_Queue
{
    class QueueSequence
    {
        static void Main(string[] args)
        {
            var startNumber = long.Parse(Console.ReadLine());

            Queue<long> seqenceQueue = new Queue<long>();
            Queue<long> seqenceStart = new Queue<long>();
            seqenceQueue.Enqueue(startNumber);
            seqenceStart.Enqueue(startNumber);

            while (seqenceQueue.Count<50)
            {
                startNumber = seqenceStart.Dequeue();

                var firstNumber = startNumber + 1;
                var secondNumber = startNumber * 2 + 1;
                var thirdNumber = startNumber + 2;

                seqenceQueue.Enqueue(firstNumber);
                seqenceQueue.Enqueue(secondNumber);
                seqenceQueue.Enqueue(thirdNumber);

                seqenceStart.Enqueue(firstNumber);
                seqenceStart.Enqueue(secondNumber);
                seqenceStart.Enqueue(thirdNumber);

            }
            int count = 0;
            while (count++<50)
            {
                Console.Write(seqenceQueue.Dequeue() + " ");
            }
        }
    }
}
