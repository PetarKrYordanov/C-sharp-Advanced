using System;
using System.Text.RegularExpressions;

namespace _04.TreasureMap
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var pattern = @"(!|#)([^|#]*?)(?<![a-zA-Z])([a-zA-Z]{4})(?![a-zA-Z0-9])[^|#]*(?<!\d)([\d]{3})*(?!\d)-(\d{4}|\d{6})(?!\d)[^|#]*?(?!\1)(#|!)";

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);

                var correctMatch = matches[matches.Count / 2];

                string streetName = correctMatch.Groups[3].Value;
                string streetNumber = correctMatch.Groups[4].Value;
                string password = correctMatch.Groups[5].Value;

                Console.WriteLine($"Go to str. {streetName} {streetNumber}. Secret pass: {password}.");
            }
        }
    }
}
