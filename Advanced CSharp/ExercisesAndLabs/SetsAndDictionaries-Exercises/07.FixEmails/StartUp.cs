namespace _07.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();
            var name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                if (!emails.ContainsKey(name) && !email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}