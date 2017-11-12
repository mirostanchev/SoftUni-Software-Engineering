public class Angry : Mood
{
    public override string GetName()
    {
        return this.GetType().Name;
    }
}