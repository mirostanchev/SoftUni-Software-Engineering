namespace _03.BarrackWars_ANewFactory
{
    using _03.BarrackWars_ANewFactory.Contracts;
    using _03.BarrackWars_ANewFactory.Core;
    using _03.BarrackWars_ANewFactory.Core.Factories;
    using _03.BarrackWars_ANewFactory.Data;

    public class StartUp
    {
        public static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            ICommandInterpreter commandInterpreter = new CommandInterpreter(repository, unitFactory);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}