namespace _09.PasswordGuess
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}