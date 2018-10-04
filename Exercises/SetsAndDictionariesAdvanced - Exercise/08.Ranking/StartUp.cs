using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class StartUp
    {
        public static Dictionary<string, Dictionary<string, int>> studentsSubmitions = new Dictionary<string, Dictionary<string, int>>();
        public static Dictionary<string, string> contestPasswords = new Dictionary<string, string>();
        static void Main(string[] args)
        {

            GetContests();

            GetSumbmitions();

            PrintBestCandidate();

            PrintCandidatesWithResults();
        }

        private static void PrintCandidatesWithResults()
        {
            Console.WriteLine("Ranking:");
            foreach (var student in studentsSubmitions.OrderBy(e=>e.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var courseResult in student.Value.OrderByDescending(e=>e.Value))
                {
                    Console.WriteLine($"#  {courseResult.Key} -> {courseResult.Value}");
                }
            }
        }

        private static void PrintBestCandidate()
        {
            var student = studentsSubmitions.OrderByDescending(e => e.Value.Values.Sum()).FirstOrDefault();
            Console.WriteLine($"Best candidate is {student.Key} with total {student.Value.Values.Sum()} points.");
        }

        private static void GetSumbmitions()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                var submitionArgs = input.Split("=>");

                var course = submitionArgs[0];
                var coursePassword = submitionArgs[1];
                var username = submitionArgs[2];
                var points = int.Parse(submitionArgs[3]);

                bool isContestValid = IsValidContest(course, coursePassword);
                if (isContestValid)
                {
                    SubmitResult(course, username, points);
                }
            }
        }

        private static void SubmitResult(string course, string username, int points)
        {
            if (studentsSubmitions.ContainsKey(username))
            {
                if (studentsSubmitions[username].ContainsKey(course))
                {
                    int previousValue = studentsSubmitions[username][course];
                    if (previousValue<points)
                    {
                        studentsSubmitions[username][course] = points;
                    }
                }
                else
                {
                    studentsSubmitions[username].Add(course, points);
                }
            }
            else
            {                
                studentsSubmitions.Add(username, new Dictionary<string, int>());
                studentsSubmitions[username].Add(course, points);
            }
        }

        private static bool IsValidContest(string course, string coursePassword)
        {
            if (contestPasswords.ContainsKey(course))
            {
                if (contestPasswords[course] == coursePassword)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private static void GetContests()
        {       
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }
                var contestArgs = input.Split(':');
                var name = contestArgs[0];
                var password = contestArgs[1];

                if (!contestPasswords.ContainsKey(name))
                {
                    contestPasswords.Add(name, password);
                }
            }
        }
    }
}
