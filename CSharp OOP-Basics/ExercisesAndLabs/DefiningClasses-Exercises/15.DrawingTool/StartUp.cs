namespace _15.DrawingTool
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var figure = Console.ReadLine();

            if (figure.Equals("Square"))
            {
                Square.DrawSquare(int.Parse(Console.ReadLine()));
            }
            else
            {
                Rectangle.DrawRectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
        }
    }
}