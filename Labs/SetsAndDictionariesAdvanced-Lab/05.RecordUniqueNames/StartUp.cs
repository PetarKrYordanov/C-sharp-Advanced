namespace _05.RecordUniqueNames
{
using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            HashSet<string> list = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }
            Console.WriteLine(string.Join(Environment.NewLine,list));
        }
    }
}
