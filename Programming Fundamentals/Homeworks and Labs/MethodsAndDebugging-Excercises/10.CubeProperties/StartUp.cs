namespace _10.CubeProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var typeCalculations = Console.ReadLine();

            if (typeCalculations == "face")
            {
                Console.WriteLine("{0:f2}", GetFaceDiagonal(side));
            }
            else if (typeCalculations == "space")
            {
                Console.WriteLine("{0:f2}", GetSpaceDiagonal(side));
            }
            else if (typeCalculations == "volume")
            {
                Console.WriteLine("{0:f2}", GetVolume(side));
            }
            else
            {
                Console.WriteLine("{0:f2}", GetArea(side));
            }
        }

        private static double GetFaceDiagonal(double a)
        {
            var diagonal = Math.Sqrt(2 * a * a);
            return diagonal;
        }

        private static double GetSpaceDiagonal(double a)
        {
            var diagonal = Math.Sqrt(3 * a * a);
            return diagonal;
        }

        private static double GetVolume(double a)
        {
            var volume = Math.Pow(a, 3);
            return volume;
        }

        private static double GetArea(double a)
        {
            var area = (6 * a * a);
            return area;
        }
    }
}