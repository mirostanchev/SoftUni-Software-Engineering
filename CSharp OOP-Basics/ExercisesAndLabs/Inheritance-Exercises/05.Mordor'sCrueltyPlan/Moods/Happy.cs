public class Happy : Mood
{
    public override string GetName()
    {
        return this.GetType().Name;
    }
}