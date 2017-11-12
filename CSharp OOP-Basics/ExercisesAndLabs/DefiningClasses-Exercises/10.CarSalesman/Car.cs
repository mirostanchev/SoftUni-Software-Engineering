namespace _10.CarSalesman
{
    using System;

    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine, string weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public override string ToString()
        {
            return $"{this.model}:" + Environment.NewLine + $"  {this.engine.Model}:" + Environment.NewLine +
                   $"    Power: {this.engine.Power}" + Environment.NewLine + $"    Displacement: {this.engine.Displacement}" + Environment.NewLine
                   + $"    Efficiency: {this.engine.Efficiency}" + Environment.NewLine + $"  Weight: {this.weight}" + Environment.NewLine +
                   $"  Color: {this.color}";
        }
    }
}