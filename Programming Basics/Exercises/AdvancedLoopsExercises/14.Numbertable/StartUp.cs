namespace _14.Numbertable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                var increase = row;
                var decrease = num;

                for (int col = 1; col <= num; col++)
                {
                    if (increase < num)
                    {
                        Console.Write(increase + " ");
                        increase++;
                    }
                    else
                    {
                        Console.Write(decrease + " ");
                        decrease--;

                    }
                }

                Console.WriteLine();
            }
        }
    }
}