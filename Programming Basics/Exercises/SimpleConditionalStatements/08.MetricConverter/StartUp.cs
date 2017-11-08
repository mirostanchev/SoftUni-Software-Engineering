namespace _08.MetricConverter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToLower();
            var output = Console.ReadLine().ToLower();

            if (input == "m")
            {
                if (output == "mm")
                {
                    number *= 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "m")
                {
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "cm")
                {
                    number *= 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mi")
                {
                    number *= 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "in")
                {
                    number *= 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "km")
                {
                    number *= 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else if (output == "ft")
                {
                    number *= 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
                else
                {
                    number *= 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else if (input == "mm")
            {
                if (output == "m")
                {
                    number /= 1000;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "mm")
                {
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "cm")
                {
                    number = number / 1000 * 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mi")
                {
                    number = number / 1000 * 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "in")
                {
                    number = number / 1000 * 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "km")
                {
                    number = number / 1000 * 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else if (output == "ft")
                {
                    number = number / 1000 * 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
                else
                {
                    number = number / 1000 * 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else if (input == "cm")
            {
                if (output == "m")
                {
                    number /= 100;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "cm")
                {
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mm")
                {
                    number = number / 100 * 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "mi")
                {
                    number = number / 100 * 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "in")
                {
                    number = number / 100 * 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "km")
                {
                    number = number / 100 * 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else if (output == "ft")
                {
                    number = number / 100 * 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
                else
                {
                    number = number / 100 * 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else if (input == "mi")
            {
                if (output == "m")
                {
                    number /= 0.000621371192;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "mi")
                {
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "cm")
                {
                    number = number / 0.000621371192 * 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mm")
                {
                    number = number / 0.000621371192 * 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "in")
                {
                    number = number / 0.000621371192 * 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "km")
                {
                    number = number / 0.000621371192 * 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else if (output == "ft")
                {
                    number = number / 0.000621371192 * 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
                else
                {
                    number = number / 0.000621371192 * 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else if (input == "in")
            {
                if (output == "m")
                {
                    number /= 39.3700787;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "in")
                {
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "cm")
                {
                    number = number / 39.3700787 * 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mm")
                {
                    number = number / 39.3700787 * 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "mi")
                {
                    number = number / 39.3700787 * 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "km")
                {
                    number = number / 39.3700787 * 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else if (output == "ft")
                {
                    number = number / 39.3700787 * 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
                else
                {
                    number = number / 39.3700787 * 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else if (input == "km")
            {
                if (output == "m")
                {
                    number /= 0.001;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "km")
                {
                    Console.WriteLine("{0} km", number);
                }
                else if (output == "cm")
                {
                    number = number / 0.001 * 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mm")
                {
                    number = number / 0.001 * 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "mi")
                {
                    number = number / 0.001 * 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "in")
                {
                    number = number / 0.001 * 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "ft")
                {
                    number = number / 0.001 * 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
                else
                {
                    number = number / 0.001 * 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else if (input == "ft")
            {
                if (output == "m")
                {
                    number /= 3.2808399;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "ft")
                {
                    Console.WriteLine("{0} ft", number);
                }
                else if (output == "cm")
                {
                    number = number / 3.2808399 * 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mm")
                {
                    number = number / 3.2808399 * 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "mi")
                {
                    number = number / 3.2808399 * 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "in")
                {
                    number = number / 3.2808399 * 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "km")
                {
                    number = number / 3.2808399 * 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else
                {
                    number = number / 3.2808399 * 1.0936133;
                    Console.WriteLine("{0} yd", number);
                }
            }
            else
            {
                if (output == "m")
                {
                    number /= 1.0936133;
                    Console.WriteLine("{0} m", number);
                }
                else if (output == "yd")
                {
                    Console.WriteLine("{0} yd", number);
                }
                else if (output == "cm")
                {
                    number = number / 1.0936133 * 100;
                    Console.WriteLine("{0} cm", number);
                }
                else if (output == "mm")
                {
                    number = number / 1.0936133 * 1000;
                    Console.WriteLine("{0} mm", number);
                }
                else if (output == "mi")
                {
                    number = number / 1.0936133 * 0.000621371192;
                    Console.WriteLine("{0} mi", number);
                }
                else if (output == "in")
                {
                    number = number / 1.0936133 * 39.3700787;
                    Console.WriteLine("{0} in", number);
                }
                else if (output == "km")
                {
                    number = number / 1.0936133 * 0.001;
                    Console.WriteLine("{0} km", number);
                }
                else
                {
                    number = number / 1.0936133 * 3.2808399;
                    Console.WriteLine("{0} ft", number);
                }
            }
        }
    }
}