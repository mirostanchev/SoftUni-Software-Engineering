namespace _06.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var teams = new Dictionary<string, Team>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var commandArgs = command.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Team")
                {
                    var teamName = commandArgs[1];
                    var team = new Team(teamName);
                    teams[teamName] = team;
                }
                else if (commandArgs[0] == "Add")
                {
                    var teamName = commandArgs[1];
                    var playerName = commandArgs[2];
                    var endurance = int.Parse(commandArgs[3]);
                    var sprint = int.Parse(commandArgs[4]);
                    var dribble = int.Parse(commandArgs[5]);
                    var passing = int.Parse(commandArgs[6]);
                    var shooting = int.Parse(commandArgs[7]);

                    if (!teams.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else
                    {
                        try
                        {
                            var currentStats = new Stats(endurance, sprint, dribble, passing, shooting);
                            var player = new Player(playerName, currentStats);
                            teams[teamName].AddPlayer(player);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                }
                else if (commandArgs[0] == "Remove")
                {
                    var teamName = commandArgs[1];
                    var playerName = commandArgs[2];

                    if (!teams.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else
                    {
                        try
                        {
                            teams[teamName].RemomePlayer(playerName);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (commandArgs[0] == "Rating")
                {
                    var teamName = commandArgs[1];

                    if (!teams.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                    }
                }
            }
        }
    }
}