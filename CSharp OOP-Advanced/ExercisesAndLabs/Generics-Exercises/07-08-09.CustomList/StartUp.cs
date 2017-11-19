namespace _07_08_09.CustomList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var list = new CustomList<string>();

            while (true)
            {
                var cmdArgs = Console.ReadLine().Split();

                if (cmdArgs[0] == "END")
                {
                    break;
                }

                switch (cmdArgs[0])
                {
                    case "Add":
                        list.Add(cmdArgs[1]);
                        break;
                    case "Remove":
                        var element = list.Remove(int.Parse(cmdArgs[1]));
                        break;
                    case "Contains":
                        var result = list.Contains(cmdArgs[1]);
                        Console.WriteLine(result ? "True" : "False");
                        break;
                    case "Swap":
                        list.Swap(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(cmdArgs[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Sort":
                        list = Sorter<string>.Sort(list);
                        break;
                    case "Print":
                        Console.WriteLine(list.Print());
                        break;
                }
            }
        }
    }
}