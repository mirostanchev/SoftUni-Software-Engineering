namespace _12.Google
{
    public class Parents
    {
        private string name;
        private string birthday;

        public Parents(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Birthday { get => this.birthday; set => this.birthday = value; }
    }
}