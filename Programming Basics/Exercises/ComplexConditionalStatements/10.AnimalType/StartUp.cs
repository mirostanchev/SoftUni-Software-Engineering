namespace _10.AnimalType
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var animal = Console.ReadLine().ToLower();

            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile": Console.WriteLine("reptile"); break;
                case "tortoise": Console.WriteLine("reptile"); break;
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}