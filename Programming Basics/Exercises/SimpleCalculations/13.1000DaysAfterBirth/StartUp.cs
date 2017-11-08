namespace _13._1000DaysAfterBirth
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var birthDate = Console.ReadLine();
            var newDate = (DateTime.ParseExact(birthDate, "dd-MM-yyyy", null).AddDays(999)).ToString("dd-MM-yyyy");

            Console.WriteLine(newDate);
        }
    }
}