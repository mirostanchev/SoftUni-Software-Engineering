namespace _09.TrafficLight
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var initialLights = Console.ReadLine().Split();
            var trafficLights = new List<ITrafficLight>();

            foreach (var light in initialLights)
            {
                trafficLights.Add(new TrafficLight(light));
            }

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                trafficLights.ForEach(l => l.Rotate());

                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}