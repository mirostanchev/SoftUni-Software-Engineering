namespace _11.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var logs = new SortedDictionary<string, Dictionary<string, int>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var logInfo = Console.ReadLine().Split();
                var ip = logInfo[0];
                var user = logInfo[1];
                var duration = int.Parse(logInfo[2]);

                var list = new List<string>();

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new Dictionary<string, int>();
                }

                if (!logs[user].ContainsKey(ip))
                {
                    logs[user][ip] = 0;
                }

                logs[user][ip] += duration;
            }

            foreach (var outer in logs)
            {
                var ips = new List<string>();

                foreach (var inner in outer.Value)
                {
                    ips.Add(inner.Key);
                }

                ips.Sort();
                Console.WriteLine($"{outer.Key}: {outer.Value.Values.Sum()} [{string.Join(", ", ips)}]");
            }
        }
    }
}