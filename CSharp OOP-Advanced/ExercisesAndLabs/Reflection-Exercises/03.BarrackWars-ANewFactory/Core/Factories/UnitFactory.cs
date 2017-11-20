namespace _03.BarrackWars_ANewFactory.Core.Factories
{
    using System;
    using _03.BarrackWars_ANewFactory.Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNameSpace = "_03.BarrackWars_ANewFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type typeUnit = Type.GetType(UnitNameSpace + unitType);
            IUnit unitInstance = (IUnit)Activator.CreateInstance(typeUnit);
            return unitInstance;
        }
    }
}