namespace _07.SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var reservationList = new HashSet<string>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }
                if (input.Length != 8)
                {
                    continue;
                }
                reservationList.Add(input);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                if (input.Length != 8)
                {
                    continue;
                }
                if (reservationList.Contains(input))
                {
                reservationList.Remove(input);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, reservationList.OrderBy(e => e)));
        }
    }
}
