namespace _13.NumberPyramid
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(num + " ");
                    num++;

                    if (num > n)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (num > n)
                {
                    break;
                }
            }
        }
    }
}