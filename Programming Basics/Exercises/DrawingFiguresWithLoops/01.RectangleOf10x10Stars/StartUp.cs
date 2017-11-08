namespace _01.RectangleOf10x10Stars
{
    public class StartUp
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}