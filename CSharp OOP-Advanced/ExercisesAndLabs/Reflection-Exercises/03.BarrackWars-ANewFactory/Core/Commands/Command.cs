namespace _03.BarrackWars_ANewFactory.Core.Commands
{
    using _03.BarrackWars_ANewFactory.Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;

        protected Command(string[] data)
        {
            this.Data = data;
        }

        protected string[] Data
        {
            get { return this.data; }
            private set { this.data = value; }
        }

        public abstract string Execute();
    }
}