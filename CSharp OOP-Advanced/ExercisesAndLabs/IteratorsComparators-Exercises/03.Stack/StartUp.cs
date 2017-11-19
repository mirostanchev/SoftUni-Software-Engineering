namespace _03.Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var customStack = new CustomStack<int>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var cmdArgs = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Push":
                        customStack.Push(cmdArgs.Skip(1).Select(int.Parse).ToArray());
                        break;
                    case "Pop":
                        customStack.Pop();
                        break;
                }
            }

            if (customStack.Any())
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in customStack)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}