namespace _07.SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);

                var car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(model, car);
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var commandArgs = command.Split();
                var model = commandArgs[1];
                var kilometers = int.Parse(commandArgs[2]);

                cars[model].Move(kilometers);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.DistanceTravelled}");
            }
        }
    }
}