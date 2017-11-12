namespace _03.WildFarm
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string inputLine;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                var animalTokens = inputLine.Split(new char[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var foodTokens = Console.ReadLine().Split(new char[] { '\t', ' ', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.GetAnimal(animalTokens);
                Food food = FoodFactory.GeFood(foodTokens);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(animal);
            }
        }
    }
}