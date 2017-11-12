namespace _10.CarSalesman
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public Engine(string model, string power, string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get => this.model; set => this.model = value; }
        public string Power { get => this.power; set => this.power = value; }
        public string Displacement { get => this.displacement; set => this.displacement = value; }
        public string Efficiency { get => this.efficiency; set => this.efficiency = value; }
    }
}