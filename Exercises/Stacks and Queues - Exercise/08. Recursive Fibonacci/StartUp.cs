using System;
using System.Diagnostics;
using System.Numerics;
using System.Threading;

namespace _08._Recursive_Fibonacci
{
    class StartUp
    {
        private static BigInteger[] fibNumbers;
        static void Main(string[] args)
        {
          
            int nthNumber = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            fibNumbers = new BigInteger[nthNumber];

            int threatArg =(int)Math.Ceiling( nthNumber * 0.4d);

            //Thread thread = new Thread(() =>
            // {
            //     GetFibonacci(threatArg);
            // });
            //thread.Start();

            BigInteger result = GetFibonacci(nthNumber);

     //    thread.Join();

            Console.WriteLine(result);
            //Console.WriteLine(string.Join("\n",fibNumbers));
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private static BigInteger GetFibonacci(int nthNumber)
        {
            if (nthNumber<=2)
            {
                return 1;
            }

            if (fibNumbers[nthNumber - 1] != 0)
            {
                return fibNumbers[nthNumber - 1];
            }

            return fibNumbers[nthNumber-1]= GetFibonacci(nthNumber - 1) + GetFibonacci(nthNumber - 2);
        }
    }
}
