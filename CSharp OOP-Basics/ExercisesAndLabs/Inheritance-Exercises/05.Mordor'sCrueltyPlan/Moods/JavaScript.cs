public class JavaScript : Mood
{
    public override string GetName()
    {
        return this.GetType().Name;
    }
}