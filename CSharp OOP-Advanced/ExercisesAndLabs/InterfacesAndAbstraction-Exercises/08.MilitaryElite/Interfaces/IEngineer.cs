﻿namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer
    {
        ICollection<IRepair> Repairs { get; }
    }
}