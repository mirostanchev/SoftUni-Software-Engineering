namespace _12.Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car()
        {
        }

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get => this.model; set => this.model = value; }
        public int Speed { get => this.speed; set => this.speed = value; }
    }
}