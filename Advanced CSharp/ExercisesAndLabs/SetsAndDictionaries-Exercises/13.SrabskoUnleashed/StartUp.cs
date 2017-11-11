namespace _13.SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var index = command.IndexOf("@");

                if (index == -1)
                {
                    continue;
                }

                var commandInfo = command.Split('@');

                if (commandInfo.Length >= 2)
                {
                    var singer = commandInfo[0].Trim();
                    var otherInfo = commandInfo[1].Split();

                    if (otherInfo.Length < 3 || !commandInfo[0].EndsWith(" "))
                    {
                        continue;
                    }

                    var ticketsCount = 0;
                    var ticketsPrice = 0;

                    try
                    {
                        ticketsCount = int.Parse(otherInfo[otherInfo.Length - 1]);
                        ticketsPrice = int.Parse(otherInfo[otherInfo.Length - 2]);
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                    var venue = string.Empty;

                    for (int i = 0; i <= otherInfo.Length - 3; i++)
                    {
                        venue += otherInfo[i] + " ";
                    }

                    venue = venue.Trim();

                    if (!result.ContainsKey(venue))
                    {
                        result[venue] = new Dictionary<string, decimal>();
                    }

                    if (!result[venue].ContainsKey(singer))
                    {
                        result[venue][singer] = 0;
                    }

                    result[venue][singer] += ticketsPrice * ticketsCount;
                }
            }

            foreach (var outer in result)
            {
                Console.WriteLine(outer.Key);

                foreach (var inner in outer.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {inner.Key} -> {inner.Value}");
                }
            }
        }
    }
}