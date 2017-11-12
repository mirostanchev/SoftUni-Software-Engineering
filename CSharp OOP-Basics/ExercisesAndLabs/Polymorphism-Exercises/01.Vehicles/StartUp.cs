namespace _01.Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandArgs = Console.ReadLine().Split();

                if (commandArgs[0] == "Drive")
                {
                    var kilometers = double.Parse(commandArgs[2]);

                    if (commandArgs[1] == "Car")
                    {
                        car.Driving(kilometers);
                    }
                    else
                    {
                        truck.Driving(kilometers);
                    }
                }
                else
                {
                    var fuel = double.Parse(commandArgs[2]);

                    if (commandArgs[1] == "Car")
                    {
                        car.Refueling(fuel);
                    }
                    else
                    {
                        truck.Refueling(fuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}