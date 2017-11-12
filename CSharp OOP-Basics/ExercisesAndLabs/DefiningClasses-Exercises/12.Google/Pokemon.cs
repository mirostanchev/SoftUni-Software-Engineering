namespace _12.Google
{
    public class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Type { get => this.type; set => this.type = value; }
    }
}