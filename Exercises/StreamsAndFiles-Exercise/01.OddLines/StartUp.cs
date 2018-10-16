using System;
using System.IO;

namespace _01.OddLines
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var basePath = @"../../../";
            var file = "text.txt";

            string path = Path.Combine(basePath, file);
            int count = 0;
            using (var reader = new StreamReader(path))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
