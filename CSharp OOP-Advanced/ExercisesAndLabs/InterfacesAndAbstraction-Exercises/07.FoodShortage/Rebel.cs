namespace _07.FoodShortage
{
    public class Rebel : IBuyer
    {
        public Rebel(string name,int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public int Age { get; }

        public string Group { get; set; }

        public string Name { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}