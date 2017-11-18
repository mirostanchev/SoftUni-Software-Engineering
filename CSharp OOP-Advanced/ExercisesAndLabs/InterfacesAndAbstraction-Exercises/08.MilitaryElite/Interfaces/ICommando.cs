namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando
    {
        ICollection<IMission> Missions { get; }
    }
}