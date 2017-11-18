namespace _08.MilitaryElite.Interfaces
{
    using _08.MilitaryElite.Enums;

    public interface IMission
    {
        string CodeName { get; }

        MissionState State { get; }

        void CompleteMission();
    }
}