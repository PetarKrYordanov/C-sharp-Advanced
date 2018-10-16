using System;
using System.Text.RegularExpressions;

namespace _01.ADataTransfer
{
    class StartUp
    {
        public static int size;
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var pattern = @"s:([^;]+);r:([^;]+);m--""([a-zA-Z\s]+)""";
            size = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                var matches = Regex.Match(input, pattern);
                    var sender = matches.Groups[1].Value;
                    var reciever = matches.Groups[2].Value;
                    var message = matches.Groups[3].Value;

                   string senderName = GetNames(sender);
                    string recieverName = GetNames(reciever);

                    Console.WriteLine($"{senderName} says \"{message}\" to {recieverName}");
                }               
            }
            Console.WriteLine($"Total data transferred: {size}MB");
        }

        private static string GetNames(string text)
        {
            var result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    result += text[i];
                }
                if (text[i] == ' ')
                {
                    result += ' ';
                }
                if (Char.IsDigit(text[i]))
                {
                    size += int.Parse(text[i].ToString());
                }
            }
            return result;
        }
    }
}
