namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();
            var name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();
                emails[name] = email;
                name = Console.ReadLine();
            }

            var fixedEmails = emails.Where(a => !a.Value.EndsWith("us", StringComparison.OrdinalIgnoreCase)
                                                && !a.Value.EndsWith("uk", StringComparison.OrdinalIgnoreCase))
                                                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var item in fixedEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}