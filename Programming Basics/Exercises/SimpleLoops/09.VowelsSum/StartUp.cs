namespace _09.VowelsSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sum += 1;
                }
                else if (text[i] == 'e')
                {
                    sum += 2;
                }
                else if (text[i] == 'i')
                {
                    sum += 3;
                }
                else if (text[i] == 'o')
                {
                    sum += 4;
                }
                else if (text[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}