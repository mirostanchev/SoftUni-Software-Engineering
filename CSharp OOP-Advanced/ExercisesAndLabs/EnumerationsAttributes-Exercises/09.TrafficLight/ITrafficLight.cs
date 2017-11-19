namespace _09.TrafficLight
{
    public interface ITrafficLight
    {
        Light Light { get; }

        void Rotate();
    }
}