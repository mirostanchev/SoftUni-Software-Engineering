namespace _01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var users = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var username = Console.ReadLine();
                users.Add(username);
            }

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}