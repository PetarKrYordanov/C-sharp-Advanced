using System;

namespace _10.TheHeiganDance
{
    class Program
    {
          private static string result;
        static void Main(string[] args)              
        {
           A asds = new B();
            Console.WriteLine(asds.x);
        }

       
    }
    class A
    {
        public int x = 7;

        public A()
        {
            x++;
        }
    }

    class B : A
    {

        public B() : base()
        {
           
        }
    }
}
