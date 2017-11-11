namespace _11.ParkingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static HashSet<string> occupied = new HashSet<string>();
        private static int rows;
        private static int cols;

        public static void Main()
        {
            ReadDimensions();
            ParkCars();
        }

        private static void ParkCars()
        {
            var parkingRow = Console.ReadLine();

            while (parkingRow != "stop")
            {
                var rowData =
                    parkingRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                var startingRow = rowData[0];
                var x = rowData[1];
                var y = rowData[2];

                var coodinates = string.Format("{0}|{1}", x, y);

                if (!occupied.Contains(coodinates))
                {
                    occupied.Add(coodinates);
                    PrintResult(true, startingRow, x, y);
                }
                else
                {
                    var isFound = false;
                    var loops = Math.Max(y - 1, cols - y);
                    var col = 0;

                    for (int i = 1; i < loops; i++)
                    {
                        var left = string.Format("{0}|{1}", x, y - i);
                        var right = string.Format("{0}|{1}", x, y + i);

                        if (!occupied.Contains(left) && y - i > 0)
                        {
                            col = y - i;
                            occupied.Add(left);
                            isFound = true;
                            break;
                        }

                        if (!occupied.Contains(right) && y + i < cols)
                        {
                            col = y + i;
                            occupied.Add(right);
                            isFound = true;
                            break;
                        }
                    }

                    PrintResult(isFound, startingRow, x, col);
                }

                parkingRow = Console.ReadLine();
            }

        }

        private static void PrintResult(bool found, int startingRow, int row, int col)
        {
            if (found)
            {
                var distance = CalculateDistance(startingRow, row, col);
                Console.WriteLine(distance);
            }
            else
            {
                Console.WriteLine("Row {0} full", row);
            }
        }

        private static void ReadDimensions()
        {
            var dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            rows = dimensions[0];
            cols = dimensions[1];
        }

        private static int CalculateDistance(int startingRow, int row, int col)
        {
            return Math.Abs(startingRow - row) + col + 1;
        }
    }
}