namespace _09.House
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            int stars = 1;

            if (num % 2 == 0)
            {
                stars = 2;
            }

            var dashes = (num - stars) / 2;

            for (int i = 1; i <= (num + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));

                dashes--;
                stars += 2;
            }

            for (int i = 1; i <= num / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', num - 2));
            }
        }
    }
}