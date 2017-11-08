namespace _11.OddEvenPosition
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var evenSum = 0d;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var oddSum = 0d;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            
            if (number == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else if (number == 1)
            {
                var second = double.Parse(Console.ReadLine());

                Console.WriteLine("OddSum=" + second);
                Console.WriteLine("OddMin=" + second);
                Console.WriteLine("OddMax=" + second);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    var currentNumber = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        if (currentNumber > evenMax)
                        {
                            evenMax = currentNumber;
                        }
                        if (currentNumber < evenMin)
                        {
                            evenMin = currentNumber;
                        }

                        evenSum += currentNumber;
                    }
                    else if (i % 2 != 0)
                    {
                        if (currentNumber > oddMax)
                        {
                            oddMax = currentNumber;
                        }
                        if (currentNumber < oddMin)
                        {
                            oddMin = currentNumber;
                        }

                        oddSum += currentNumber;
                    }
                }

                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=" + oddMin);
                Console.WriteLine("OddMax=" + oddMax);
                Console.WriteLine("EvenSum=" + evenSum);
                Console.WriteLine("EvenMin=" + evenMin);
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}