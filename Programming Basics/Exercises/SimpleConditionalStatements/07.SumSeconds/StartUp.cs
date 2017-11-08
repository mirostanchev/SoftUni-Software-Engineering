namespace _07.SumSeconds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            
            var totalTime = first + second + third;
            var minutes = totalTime / 60;
            var seconds = totalTime % 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}