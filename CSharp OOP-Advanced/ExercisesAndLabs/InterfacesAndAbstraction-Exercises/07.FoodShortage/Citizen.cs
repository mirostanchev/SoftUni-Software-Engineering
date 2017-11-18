namespace _07.FoodShortage
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, int age,string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; set; }

        public string Birthdate { get; set; }

        public string Name { get; }

        public int Age { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}