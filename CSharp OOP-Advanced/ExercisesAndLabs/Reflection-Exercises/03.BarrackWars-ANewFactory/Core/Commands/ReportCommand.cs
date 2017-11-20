namespace _03.BarrackWars_ANewFactory.Core.Commands
{
    using _03.BarrackWars_ANewFactory.Attributes;
    using _03.BarrackWars_ANewFactory.Contracts;

    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            string output = this.repository.Statistics;
            return output;
        }
    }
}