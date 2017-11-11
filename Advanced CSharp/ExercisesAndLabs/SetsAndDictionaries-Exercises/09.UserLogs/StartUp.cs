namespace _09.UserLogs
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var logs = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                var commandArgs = command.Split();
                var ipInfo = commandArgs[0].Split('=');
                var userInfo = commandArgs[2].Split('=');

                var ip = ipInfo[1];
                var user = userInfo[1];

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new Dictionary<string, int>();
                }

                if (!logs[user].ContainsKey(ip))
                {
                    logs[user][ip] = 0;
                }

                logs[user][ip]++;
            }

            foreach (var outer in logs)
            {
                Console.WriteLine($"{outer.Key}: ");
                var printList = new List<string>();

                foreach (var inner in outer.Value)
                {
                    var text = $"{inner.Key} => {inner.Value}";
                    printList.Add(text);
                }

                Console.WriteLine(string.Join(", ", printList) + ".");
            }
        }
    }
}