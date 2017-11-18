namespace _01.Shapes
{
    using System;
    using System.Text;

    public class Circle : IDrawable
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public void Draw()
        {
            var sb = new StringBuilder();

            var rIn = this.Radius - 0.4;
            var rOut = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    var value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

                sb.AppendLine();
            }

            Console.Write(sb);
        }
    }
}