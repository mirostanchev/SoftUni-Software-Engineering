namespace _11.EnterEvenNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    var num = int.Parse(Console.ReadLine());

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: " + num);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}