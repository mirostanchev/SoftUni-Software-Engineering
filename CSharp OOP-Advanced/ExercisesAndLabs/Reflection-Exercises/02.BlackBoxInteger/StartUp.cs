namespace _02.BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInt);
            var instance = (BlackBoxInt)Activator.CreateInstance(type, true);

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var tokens = command.Split('_');
                var commandType = tokens[0];
                var value = int.Parse(tokens[1]);

                switch (commandType)
                {
                    case "Add":
                        var method = type.GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance);
                        method.Invoke(instance, new object[] {value});
                        int result = GetValue(type, instance);
                        Console.WriteLine(result);
                        break;
                    case "Subtract":
                        method = type.GetMethod("Subtract", BindingFlags.NonPublic | BindingFlags.Instance);
                        method.Invoke(instance, new object[] {value});
                        result = GetValue(type, instance);
                        Console.WriteLine(result);
                        break;
                    case "Multiply":
                        method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
                        method.Invoke(instance, new object[] {value});
                        result = GetValue(type, instance);
                        Console.WriteLine(result);
                        break;
                    case "Divide":
                        method = type.GetMethod("Divide", BindingFlags.NonPublic | BindingFlags.Instance);
                        method.Invoke(instance, new object[] {value});
                        result = GetValue(type, instance);
                        Console.WriteLine(result);
                        break;
                    case "RightShift":
                        method = type.GetMethod("RightShift", BindingFlags.NonPublic | BindingFlags.Instance);
                        method.Invoke(instance, new object[] {value});
                        result = GetValue(type, instance);
                        Console.WriteLine(result);
                        break;
                    case "LeftShift":
                        method = type.GetMethod("LeftShift", BindingFlags.NonPublic | BindingFlags.Instance);
                        method.Invoke(instance, new object[] {value});
                        result = GetValue(type, instance);
                        Console.WriteLine(result);
                        break;
                }
            }
        }

        private static int GetValue(Type type, BlackBoxInt instance)
        {
            var field = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
            var result = (int)field.GetValue(instance);
            return result;
        }
    }
}