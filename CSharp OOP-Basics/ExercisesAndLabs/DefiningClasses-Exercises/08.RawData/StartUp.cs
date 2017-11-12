namespace _08.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, List<Car>>();

            for (int i = 0; i < n; i++)
            {
                var lineArgs = Console.ReadLine().Split();

                var model = lineArgs[0];
                var engineSpeed = int.Parse(lineArgs[1]);
                var enginePower = int.Parse(lineArgs[2]);
                var cargoWeight = int.Parse(lineArgs[3]);
                var cargoType = lineArgs[4];
                var tire1Pressure = double.Parse(lineArgs[5]);
                var tire1Age = int.Parse(lineArgs[6]);
                var tire2Pressure = double.Parse(lineArgs[7]);
                var tire2Age = int.Parse(lineArgs[8]);
                var tire3Pressure = double.Parse(lineArgs[9]);
                var tire3Age = int.Parse(lineArgs[10]);
                var tire4Pressure = double.Parse(lineArgs[11]);
                var tire4Age = int.Parse(lineArgs[12]);

                var tire1 = new Tire(tire1Pressure, tire1Age);
                var tire2 = new Tire(tire2Pressure, tire2Age);
                var tire3 = new Tire(tire3Pressure, tire3Age);
                var tire4 = new Tire(tire4Pressure, tire4Age);

                var tires = new List<Tire>();
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);

                var cargo = new Cargo(cargoType, cargoWeight);
                var engine = new Engine(engineSpeed, enginePower);

                var car = new Car(model, engine, cargo, tires);
                if (!cars.ContainsKey(cargoType))
                {
                    cars[cargoType] = new List<Car>();
                }
                cars[cargoType].Add(car);
            }

            var filter = Console.ReadLine();

            if (filter == "fragile")
            {
                foreach (var car in cars[filter])
                {
                    if (car.Tires.Any(x => x.Pressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (filter == "flamable")
            {
                foreach (var car in cars[filter])
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}