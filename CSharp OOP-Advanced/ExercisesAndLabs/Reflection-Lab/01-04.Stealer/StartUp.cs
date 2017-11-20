namespace _01_04.Stealer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();
            var result = spy.CollectGettersAndSetters("_01_04.Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}