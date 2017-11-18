namespace _01.Shapes
{
    using System;
    using System.Text;

    public class Rectangle : IDrawable
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; private set; }

        public double Width { get; private set; }

        public void Draw()
        {
            var sb = new StringBuilder();

            for (int row = 0; row < this.Height; row++)
            {
                if (row == 0 || row == this.Height - 1)
                {
                    for (int col = 0; col < this.Width; col++)
                    {
                        sb.Append("*");
                    }
                }
                else
                {
                    for (int col = 0; col < this.Width; col++)
                    {
                        if (col == 0 || col == this.Width - 1)
                        {
                            sb.Append("*");
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }
                }

                sb.AppendLine();
            }

            Console.Write(sb);
        }
    }
}