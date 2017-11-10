namespace _10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var towns = ReadTownsAndStudents();
            var groups = DistributeStudentsIntoGroup(towns);

            PrintGroups(groups, towns);
        }

        public static void PrintGroups(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Distinct().Count()} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                var emails = group.Students.Select(x => x.Email).ToList();
                Console.Write($"{group.Town.Name} => ");
                Console.WriteLine(string.Join(", ", emails));
            }
        }

        private static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();
            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("End"))
            {
                if (inputLine.Contains("=>"))
                {
                    var town = new Town();
                    var townArgs = inputLine
                        .Split(new char[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var townName = string.Empty;

                    if (townArgs.Length > 3)
                    {
                        townName = townArgs[0] + " " + townArgs[1];
                    }
                    else
                    {
                        townName = townArgs[0];
                    }

                    var seatsCount = int.Parse(townArgs[townArgs.Length - 2]);

                    town.Name = townName;
                    town.SeatsCount = seatsCount;
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    var student = new Student();
                    var studentArgs = inputLine.Split('|').ToArray();

                    var studentName = studentArgs[0];
                    var studentEmail = studentArgs[1].Trim();
                    DateTime regDate = DateTime.ParseExact(studentArgs[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    student.Name = studentName;
                    student.Email = studentEmail;
                    student.RegistrationDate = regDate;
                    towns.Last().Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }

        private static List<Group> DistributeStudentsIntoGroup(List<Town> towns)
        {
            var groups = new List<Group>();
            towns = towns.OrderBy(x => x.Name).ToList();

            foreach (var town in towns)
            {
                var studentsInTown = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (studentsInTown.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = studentsInTown.Take(group.Town.SeatsCount).ToList();
                    studentsInTown = studentsInTown.Skip(group.Town.SeatsCount).ToList();
                    groups.Add(group);
                }
            }

            return groups;
        }
    }
}