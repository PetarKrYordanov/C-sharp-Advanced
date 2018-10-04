using System;

namespace _4._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());
           

            var triangle = new long[height][];

            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new long[currentHeight+1];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentHeight] = 1;
         

                if (currentHeight>=2)
                {
                    for (int widthCounter = 1; widthCounter <= currentHeight-1; widthCounter++)
                    {
                        triangle[currentHeight][widthCounter] =
                                triangle[currentHeight - 1][widthCounter - 1] + triangle[currentHeight - 1][widthCounter];
                    }
                }
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ",row));
            }

            //for (int i = 0; i < triangle.Length; i++)
            //{
            //    var space = new string(' ',triangle.Length -i);
            //    Console.Write(space);
            //    Console.WriteLine(string.Join(' ',triangle[i]));
            //}
        }
    }
}
