    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace _02.Tagram
    {
        class StartUp
        {
            static void Main(string[] args)
            {
                var users = new Dictionary<string, Dictionary<string, int>>();
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "end")
                    {
                        break;
                    }
                    var inputArgs = input.Split(" -> ");
                    if (input.StartsWith("ban"))
                    {
                    inputArgs = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                        var userToDelete = inputArgs[1].Trim();
                        if (users.ContainsKey(userToDelete))
                        {
                            users.Remove(userToDelete);
                        }
                        continue;
                    }
                    var username = inputArgs[0];
                    var tag = inputArgs[1];
                    var likes = int.Parse(inputArgs[2]);

                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, int>();
                    }

                    if (!users[username].ContainsKey(tag))
                    {
                        users[username][tag] = likes;
                    }
                    else
                    {
                        users[username][tag] += likes;
                    }
                }

                users = users.OrderByDescending(e => e.Value.Sum(x => x.Value)).ThenByDescending(e=>e.Key).ToDictionary(x => x.Key, y => y.Value);

                foreach (var u in users)
                {
                    Console.WriteLine(u.Key);
                    foreach (var tagLikes in u.Value)
                    {
                        Console.WriteLine($"- {tagLikes.Key}: {tagLikes.Value}");
                    }
                }
            }
        }
    }
