namespace _07.TheV_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public static Dictionary<string, List<string>> VLoggersFollowers = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> UsersFollowing = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                var inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs[1] == "joined")
                {
                    var follower = inputArgs[0];
                    AddUserToVLoggers(follower);
                }
                else if (inputArgs[1] == "followed")
                {
                    var follower = inputArgs[0];
                    var username = inputArgs[2];
                    AddFollowers(follower, username);
                }
            }

            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine($"The V-Logger has a total of {VLoggersFollowers.Count} vloggers in its logs.");

            var count = 1;
            foreach (var item in VLoggersFollowers.OrderByDescending(e => e.Value.Count)
                .ThenBy(e => UsersFollowing[e.Key].Count))
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value.Count} followers, {UsersFollowing[item.Key].Count} following");
                if (count == 1)
                {
                    foreach (var follower in item.Value.OrderBy(e => e))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }

        }

        private static void AddFollowers(string follower, string username)
        {
            if (username == follower)
            {
                return;
            }
            if (!VLoggersFollowers.ContainsKey(follower) || !VLoggersFollowers.ContainsKey(username))
            {
                return;
            }

            if (VLoggersFollowers[username].Any(f => f == follower))
            {
                return;
            }

            if (UsersFollowing[follower].Any(u => u == username))
            {
                return;
            }
            else
            {
                VLoggersFollowers[username].Add(follower);
                UsersFollowing[follower].Add(username);
            }
        }

        private static void AddUserToVLoggers(string username)
        {
            if (!VLoggersFollowers.ContainsKey(username))
            {
                VLoggersFollowers.Add(username, new List<string>(2));
            }

            if (!UsersFollowing.ContainsKey(username))
            {
                UsersFollowing.Add(username, new List<string>(2));
            }
        }
    }
}
