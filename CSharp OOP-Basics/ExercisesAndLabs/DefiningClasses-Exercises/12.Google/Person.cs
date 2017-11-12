namespace _12.Google
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemon;
        private List<Parents> parents;
        private List<Children> children;
        private Car car;

        public Person(string name)
        {
            this.name = name;
            this.company = new Company();
            this.pokemon = new List<Pokemon>();
            this.parents = new List<Parents>();
            this.children = new List<Children>();
            this.car = new Car();
        }

        public string Name { get => this.name; set => this.name = value; }
        public Company Company { get => this.company; set => this.company = value; }
        public List<Pokemon> Pokemon { get => this.pokemon; set => this.pokemon = value; }
        public List<Parents> Parents { get => this.parents; set => this.parents = value; }
        public List<Children> Children { get => this.children; set => this.children = value; }
        public Car Car { get => this.car; set => this.car = value; }

    }
}