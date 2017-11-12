namespace _14.CatLady
{
    public class Cat
    {
        private string type;
        private string name;
        private double furSize;
        private int earSize;
        private int decibels;

        public string Type { get => this.type; set => this.type = value; }
        public string Name { get => this.name; set => this.name = value; }
        public double FurSize { get => this.furSize; set => this.furSize = value; }
        public int EarSize { get => this.earSize; set => this.earSize = value; }
        public int Decibels { get => this.decibels; set => this.decibels = value; }
    }
}