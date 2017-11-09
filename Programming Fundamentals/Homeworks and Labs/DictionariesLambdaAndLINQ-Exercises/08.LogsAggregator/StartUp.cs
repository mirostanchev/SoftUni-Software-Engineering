namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                var lineArgs = Console.ReadLine().Split().ToArray();

                var username = lineArgs[1];
                var ipAddress = lineArgs[0];
                var duration = int.Parse(lineArgs[2]);

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new SortedDictionary<string, int>());
                }

                if (!users[username].ContainsKey(ipAddress))
                {
                    users[username].Add(ipAddress, 0);
                }

                users[username][ipAddress] += duration;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", user.Value.Keys)}]");
            }
        }
    }
}