namespace _02.AverageStudentGrades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            var gradeBook = new Dictionary<string, List<double>>();

            gradeBook = GetStudentMarks();

            PrintResult(gradeBook);
        }

        private static void PrintResult(Dictionary<string, List<double>> gradeBook)
        {
            foreach (var item in gradeBook)
            {
                Console.WriteLine($"{item.Key} -> " +
                    $"{string.Join(' ', item.Value.Select(x=>string.Format("{0:f2}",x)))} " +
                    $"(avg: {item.Value.Average():f2})");
            }
        }

        private static Dictionary<string, List<double>> GetStudentMarks()
        {
            var lines = int.Parse(Console.ReadLine());
            var gradeBook = new Dictionary<string, List<double>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var grade = double.Parse(input[1]);

                if (gradeBook.ContainsKey(name))
                {
                    gradeBook[name].Add(grade);
                }
                else
                {
                    gradeBook.Add(name, new List<double>());
                    gradeBook[name].Add(grade);
                }

            }
            return gradeBook;
        }
    }
}
