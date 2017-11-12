namespace _02.VehiclesExtension
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(carInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

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
                    else if (commandArgs[1] == "Truck")
                    {
                        truck.Driving(kilometers);
                    }
                    else
                    {
                        bus.Driving(kilometers);
                    }
                }
                else if (commandArgs[0] == "Refuel")
                {
                    var fuel = double.Parse(commandArgs[2]);

                    if (commandArgs[1] == "Car")
                    {
                        car.Refueling(fuel);
                    }
                    else if (commandArgs[1] == "Truck")
                    {
                        truck.Refueling(fuel);
                    }
                    else
                    {
                        bus.Refueling(fuel);
                    }
                }
                else
                {
                    bus.DriveEmpty(double.Parse(commandArgs[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}