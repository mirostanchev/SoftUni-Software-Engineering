namespace _10.HalfSumElement
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNumber = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }

                sum += currentNum;
            }

            sum -= maxNumber;

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - maxNumber));
            }
        }
    }
}