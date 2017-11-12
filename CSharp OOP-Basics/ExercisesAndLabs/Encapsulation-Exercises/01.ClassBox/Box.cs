namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            var area = (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
            return area;
        }

        public double GetLateralArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            var area = (2 * this.length * this.height) + (2 * this.width * this.height);
            return area;
        }

        public double GetVolume()
        {
            //Volume = lwh
            var volume = this.length * this.width * this.height;
            return volume;
        }
    }
}