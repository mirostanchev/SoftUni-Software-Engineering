namespace _10.CustomClassAttribute
{
    using System;
    using System.Linq;

    [Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class StartUp
    {
        public static void Main()
        {
            var input = string.Empty;
            var attr = (CustomAttribute)typeof(StartUp)
                .GetCustomAttributes(true)
                .First();

            while ((input = Console.ReadLine()) != "END")
            {
                attr.PrintInfo(input);
            }
        }
    }
}