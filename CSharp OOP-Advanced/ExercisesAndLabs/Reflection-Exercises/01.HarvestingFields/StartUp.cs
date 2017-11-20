namespace _01.HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "HARVEST")
                {
                    break;
                }

                var type = typeof(HarvestingFields);

                if (command == "private")
                {
                    var privateFields =
                        type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).Where(f => f.IsPrivate);

                    PrintFields(privateFields);
                }
                else if (command == "protected")
                {
                    var protectedFields =
                        type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).Where(f => f.IsFamily);

                    PrintFields(protectedFields);
                }
                else if (command == "public")
                {
                    var publicFields =
                        type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).Where(f => f.IsPublic);

                    PrintFields(publicFields);
                }
                else if (command == "all")
                {
                    var allFields =
                        type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

                    PrintFields(allFields);
                }
            }
        }

        private static void PrintFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                if (field.Attributes.ToString() == "Family")
                {
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                }
                else
                {
                    Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}