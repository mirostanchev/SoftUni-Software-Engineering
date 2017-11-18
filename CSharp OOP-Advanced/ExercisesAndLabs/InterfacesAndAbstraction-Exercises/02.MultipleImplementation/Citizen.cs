using _02.MultipleImplementation;

public class Citizen : IBirthable,IIdentifiable
{
    public Citizen(string name, int age, string birthday, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Birthday = birthday;
        this.Id = id;
    }

    public string Name { get; }
    public int Age { get; }
    public string Birthday { get; }
    public string Id { get; }
}