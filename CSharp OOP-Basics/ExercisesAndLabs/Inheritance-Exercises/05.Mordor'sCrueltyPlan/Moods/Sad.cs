public class Sad : Mood
{
    public override string GetName()
    {
        return this.GetType().Name;
    }
}