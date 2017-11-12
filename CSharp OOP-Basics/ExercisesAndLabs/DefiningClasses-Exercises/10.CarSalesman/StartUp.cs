namespace _10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = engineArgs[0];
                var power = engineArgs[1];
                var efficiency = "n/a";
                var displacement = "n/a";

                if (engineArgs.Length == 4)
                {
                    displacement = engineArgs[2];
                    efficiency = engineArgs[3];
                }
                else if (engineArgs.Length == 3)
                {
                    int res;
                    var isNum = int.TryParse(engineArgs[2], out res);

                    if (isNum)
                    {
                        displacement = engineArgs[2];
                    }
                    else
                    {
                        efficiency = engineArgs[2];
                    }
                }

                var engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = carArgs[0];
                var searchedEngine = carArgs[1];
                var engine = engines.First(x => x.Model == searchedEngine);
                var weight = "n/a";
                var color = "n/a";

                if (carArgs.Length == 4)
                {
                    weight = carArgs[2];
                    color = carArgs[3];
                }
                else if (carArgs.Length == 3)
                {
                    int res;
                    var isNum = int.TryParse(carArgs[2], out res);

                    if (isNum)
                    {
                        weight = carArgs[2];
                    }
                    else
                    {
                        color = carArgs[2];
                    }
                }

                var car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}