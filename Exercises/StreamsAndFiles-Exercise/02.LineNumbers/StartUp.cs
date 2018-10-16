using System;
using System.IO;

namespace _02.LineNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var basePath = @"../../../";
            var file = "text.txt";

            string path = Path.Combine(basePath, file);
            string outputPath = Path.Combine(basePath, "output.txt");
            int count = 1;
            using (var writer = new StreamWriter(outputPath))
            {
                using (var reader = new StreamReader(path))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"Line {count}: {line}");
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
