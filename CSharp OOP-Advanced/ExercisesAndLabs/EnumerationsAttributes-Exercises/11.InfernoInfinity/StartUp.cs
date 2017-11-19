namespace _11.InfernoInfinity
{
    using _11.InfernoInfinity.Engine;

    public class StartUp
    {
        public static void Main()
        {
            var commandInterpreter = new CommandInterpreter();
            commandInterpreter.StartReadingCommands();
        }
    }
}