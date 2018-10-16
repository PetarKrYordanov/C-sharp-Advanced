using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var basePath = @"../../../";
            var dictionary = new Dictionary<string, int>();
            string wordsPath = Path.Combine(basePath, "words.txt");
            string outputPath = Path.Combine(basePath, "result.txt");
            string textPath = Path.Combine(basePath, "text.txt");
            var words = new HashSet<string>();
            using (var reader = new StreamReader(wordsPath))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    words.Add(line);
                    line = reader.ReadLine();
                }
            }

            using (var reader = new StreamReader(textPath))
            {
                using (var writer = new StreamWriter(outputPath))
                {
                    var text = reader.ReadToEnd().ToLower().Split(new char[] { ' ', '\t', '-', '.', ',','-','?','!' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        var num = text.Where(e => e.Equals(word.ToLower())).Count();
                        dictionary[word] = num;                        
                    }

                    foreach (var item in dictionary.OrderByDescending(e => e.Value))
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }

        }
    }
}
