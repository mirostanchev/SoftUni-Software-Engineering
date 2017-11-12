namespace _12.Google
{
    public class Children
    {
        private string name;
        private string birthday;

        public Children(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Birthday { get => this.birthday; set => this.birthday = value; }
    }
}